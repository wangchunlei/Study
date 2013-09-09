using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OfficeAutomatic.Models;
using Syncfusion.Mvc.Schedule;
using Syncfusion.Mvc.Shared;
using Syncfusion.Mvc.Tools;

namespace OfficeAutomatic.Controllers
{
    [Authorize]
    public class ScheduleController : Controller
    {
        public ActionResult Schedule(SchedulePropertiesModel model)
        {
            ViewData["ScheduleModel"] = model;
            var queryString = Request.QueryString;

            DatePickerModel dtPicker = new DatePickerModel();
            dtPicker.ChangeMonth = true;
            dtPicker.ChangeYear = true;
            dtPicker.AutoFormat = ((Skins)model.Skins);
            ViewData["DatePickerModel"] = dtPicker;
            Session["ParentID"] = queryString["parentID"];
            Session["ScheduleType"] = queryString["scheduleType"];
            IList<Seminar> seminars;
            var parentId = Guid.Parse(queryString["parentID"]);
            var scheduleType = int.Parse(queryString["scheduleType"]);
            using (var context = new OfficeContext())
            {
                seminars = context.Seminars.Where(s => s.ParentID == parentId && s.ScheduleType == (ScheduleType)scheduleType).ToList();
            }

            return View(seminars);
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Schedule(Params args, Schedule scheduleObject)
        {
            scheduleObject.SetCurrentCultureInfo();
            ActionResult result = null;
            var parentID = Guid.Parse(Session["ParentID"].ToString());
            var scheduleType = (ScheduleType)int.Parse(Session["ScheduleType"].ToString());
            using (var context = new OfficeContext())
            {
                if (args.CurrentAction == "Save")
                {
                    var startTime = DateTime.Parse(args.StartTime.Replace("上午", "AM").Replace("下午", "PM"));
                    var endTime = DateTime.Parse(args.EndTime.Replace("上午", "AM").Replace("下午", "PM"));
                    Seminar appoint = new Seminar()
                    {
                        StartTime = startTime,
                        EndTime = endTime,
                        Subject = args.Subject,
                        Location = args.Location,
                        Description = args.Description,
                        Owner = args.Owner,
                        Priority = args.Priority,
                        Recurrence = args.Recurrence,
                        RecurrenceType = args.RecurrenceType,
                        RecurrenceCount = Convert.ToInt16(args.RecurrenceTypeCount),
                        Reminder = args.Reminder,
                        Categorize = args.Categorize,
                        AllDay = args.AllDay,
                        RecurrenceEndDate = args.RecurrenceEnd != null ? Convert.ToDateTime(args.RecurrenceEnd) : endTime,
                        RecurrenceStartDate = args.RecurrenceStart != null ? Convert.ToDateTime(args.RecurrenceStart) : startTime,
                        RecurrenceRule = args.RecurrenceRules,
                        ParentID = parentID,
                        ScheduleType = scheduleType,
                        CurrentUser = User.Identity.Name
                    };
                    context.Seminars.Add(appoint);
                    context.SaveChanges();
                }
                else if (args.CurrentAction == "EditOccurrence")
                {
                    //SeminarRepository.EditOccurrence(args);
                }
                else if (args.CurrentAction == "Edit")
                {
                    var appid = int.Parse(args.AppID);
                    var point = context.Seminars.Single(s => s.Id == appid);
                    var startTime = DateTime.Parse(args.StartTime.Replace("上午", "AM").Replace("下午", "PM"));
                    var endTime = DateTime.Parse(args.EndTime.Replace("上午", "AM").Replace("下午", "PM"));

                    point.StartTime = startTime;
                    point.EndTime = endTime;
                    point.Subject = args.Subject;
                    point.Location = args.Location;
                    point.Description = args.Description;
                    point.Owner = args.Owner;
                    point.Priority = args.Priority;
                    point.Recurrence = args.Recurrence;
                    point.RecurrenceType = args.RecurrenceType;
                    point.RecurrenceCount = Convert.ToInt16(args.RecurrenceTypeCount);
                    point.Reminder = args.Reminder;
                    point.Categorize = args.Categorize;
                    point.AllDay = args.AllDay;
                    point.RecurrenceEndDate = args.RecurrenceEnd != null ? Convert.ToDateTime(args.RecurrenceEnd) : endTime;
                    point.RecurrenceStartDate = args.RecurrenceStart != null ? Convert.ToDateTime(args.RecurrenceStart) : startTime;
                    point.RecurrenceRule = args.RecurrenceRules;
                    point.ParentID = parentID;
                    point.ScheduleType = scheduleType;
                    point.CurrentUser = User.Identity.Name;
                    //context.Seminars.Add(point);
                    context.SaveChanges();
                }
                else if (args.CurrentAction == "Delete")
                {
                    var appid = int.Parse(args.AppID);
                    var point = context.Seminars.Single(s => s.Id == appid);
                    context.Seminars.Remove(point);
                    context.SaveChanges();
                }
                else if (args.CurrentAction == "DismissAll" || args.CurrentAction == "Dismiss" || args.CurrentAction == "Snooze")
                {
                    //SeminarRepository.ReminderAction(args);
                }

                result = context.Seminars.Where(s => s.ParentID == parentID && s.ScheduleType == (ScheduleType)scheduleType).ToList().ScheduleActions<ScheduleHtmlActionResult>();
            }

            return result;
        }
    }
}

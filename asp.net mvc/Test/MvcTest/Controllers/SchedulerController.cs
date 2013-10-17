using Domas.Web.Mvc.UI;
using MvcTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domas.Web.Mvc.Extensions;

namespace MvcTest.Controllers
{
    public class SchedulerController : Controller
    {
        //
        // GET: /Scheduler/

        public ActionResult Index()
        {
            return View();
        }

        public virtual JsonResult Read([DataSourceRequest] DataSourceRequest request)
        {
            //return Json(taskService.GetAll().ToDataSourceResult(request));
            var tasks = new List<TaskViewModel>();
            tasks.Add(new TaskViewModel()
            {
                TaskID=1,Description="2小时内租用0021车",OwnerID=2,Start=DateTime.Now,End=DateTime.Now.AddHours(2),Title="租车"
            });

            tasks.Add(new TaskViewModel()
            {
                TaskID = 2,
                Description = "下午2点 -- 4点占用会议室 213",
                OwnerID = 2,
                Start = DateTime.Now.Date.AddHours(14),
                End = DateTime.Now.Date.AddHours(16),

                Title = "申请会议室"
            });

            return Json(tasks.ToDataSourceResult(request));
        }

        public virtual JsonResult Destroy([DataSourceRequest] DataSourceRequest request, TaskViewModel task)
        {
            //if (ModelState.IsValid)
            //{
            //    taskService.Delete(task, ModelState);
            //}

            //return Json(new[] { task }.ToDataSourceResult(request, ModelState));
            return null;
        }

        public virtual JsonResult Create([DataSourceRequest] DataSourceRequest request, TaskViewModel task)
        {
            //if (ModelState.IsValid)
            //{
            //    taskService.Insert(task, ModelState);
            //}

            //return Json(new[] { task }.ToDataSourceResult(request, ModelState));
            return null;
        }

        public virtual JsonResult Update([DataSourceRequest] DataSourceRequest request, TaskViewModel task)
        {
            //if (ModelState.IsValid)
            //{
            //    taskService.Update(task, ModelState);
            //}

            //return Json(new[] { task }.ToDataSourceResult(request, ModelState));
            return null;
        }
    }
}

using Domas.Web.Mvc.UI;
using MvcTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            return null;
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

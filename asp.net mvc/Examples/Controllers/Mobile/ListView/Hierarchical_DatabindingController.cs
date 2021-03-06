﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domas.Web.Mvc.Extensions;
using Domas.Web.Mvc.Examples.Models;
using Domas.Web.Mvc.UI;

namespace Domas.Web.Mvc.Examples.Controllers.Mobile
{
    public partial class ListViewController : Controller
    {       
        public ActionResult Hierarchical_Databinding()
        {
            return View();
        }

        public JsonResult Employees(int? EmployeeId)
        {
            var dataContext = new NorthwindDataContext();

            var employees = from e in dataContext.Employees
                            where (EmployeeId.HasValue ? e.ReportsTo == EmployeeId : e.ReportsTo == null)
                            select new
                            {
                                EmployeeId = e.EmployeeID,
                                FullName = e.FirstName + " " + e.LastName,
                                HasEmployees = e.Employees.Any()
                            };

            return Json(employees, JsonRequestBehavior.AllowGet);
        }
    }
}

using System;
using System.Web.Mvc;

namespace Domas.Web.Mvc.Examples.Controllers
{
    public partial class CalendarController : Controller
    {
        public ActionResult SelectAction(DateTime? date)
        {
            ViewBag.date = date;

            return View();
        }
    }
}
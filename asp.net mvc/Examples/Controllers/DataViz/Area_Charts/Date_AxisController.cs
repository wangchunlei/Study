using System;
using System.Linq;
using System.Web.Mvc;
using Domas.Web.Mvc.Examples.Models;

namespace Domas.Web.Mvc.Examples.Controllers
{
    public partial class Area_ChartsController : Controller
    {
        public ActionResult Date_Axis()
        {
            return View(ChartDataRepository.DatePoints());
        }
    }
}
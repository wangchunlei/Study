using System;
using System.Linq;
using System.Web.Mvc;
using Domas.Web.Mvc.Examples.Models;

namespace Domas.Web.Mvc.Examples.Controllers
{
    public partial class CustomizationController : Controller
    {
        public ActionResult PlotBands()
        {
            return View();
        }

        public ActionResult _SpainElectricityProduction()
        {
            return Json(ChartDataRepository.SpainElectricityProduction());
        }
    }
}
using System;
using System.Linq;
using System.Web.Mvc;
using Domas.Web.Mvc.Examples.Models;

namespace Domas.Web.Mvc.Examples.Controllers
{
    public partial class Scatter_ChartsController : Controller
    {
        public ActionResult Multiple_Axes()
        {
            return View(ChartDataRepository.EngineData());
        }
    }
}
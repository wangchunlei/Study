﻿using System;
using System.Linq;
using System.Web.Mvc;
using Domas.Web.Mvc.Examples.Models;

namespace Domas.Web.Mvc.Examples.Controllers
{
    public partial class Donut_ChartsController : Controller
    {
        public ActionResult Local_Data()
        {
            return View(ChartDataRepository.SpainElectricityBreakdown());
        }
    }
}
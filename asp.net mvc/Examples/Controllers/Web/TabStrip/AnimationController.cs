﻿using System.Web.Mvc;

namespace Domas.Web.Mvc.Examples.Controllers
{
    public partial class TabStripController : Controller
    {
        public ActionResult Animation(string animation, bool? opacity)
        {
            ViewBag.animation = animation ?? "expand";
            ViewBag.opacity = opacity ?? true;

            return View();
        }
    }
}
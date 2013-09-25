using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web.Mvc;
using Domas.Web.Mvc.Examples.Models;
using Domas.Web.Mvc.Extensions;
using Domas.Web.Mvc.UI;
using System;

namespace Domas.Web.Mvc.Examples.Controllers
{
    public partial class ListViewController : Controller
    {
        public ActionResult Rtl()
        {
            return View(GetProducts());
        }
    }
}
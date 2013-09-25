using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domas.Web.Mvc.UI;
using Domas.Web.Mvc.Extensions;
using Domas.Web.Mvc.Examples.Models;

namespace Domas.Web.Mvc.Examples.Controllers.Mobile
{
    public partial class ListViewController : Controller
    {       
        public ActionResult Filtering()
        {
            return View();
        }

        public ActionResult Filtering_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(SessionProductRepository.All().ToDataSourceResult(request));
        }     
    }
}

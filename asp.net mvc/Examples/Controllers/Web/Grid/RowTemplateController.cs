using System.Web.Mvc;
using Domas.Web.Mvc.UI;
using Domas.Web.Mvc.Examples.Models;
using Domas.Web.Mvc.Extensions;

namespace Domas.Web.Mvc.Examples.Controllers
{
    public partial class GridController : Controller
    {
        public ActionResult RowTemplate()
        {
            return View();
        }

        public ActionResult RowTemplate_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(GetEmployees().ToDataSourceResult(request));
        }
    }
}
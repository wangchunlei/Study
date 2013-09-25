using System.Web.Mvc;
using Domas.Web.Mvc.Extensions;
using Domas.Web.Mvc.UI;

namespace Domas.Web.Mvc.Examples.Controllers
{
    public partial class GridController : Controller
    {
        public ActionResult Aggregates()
        {
            return View();
        }
        
        public ActionResult Aggregates_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(GetProducts().ToDataSourceResult(request));
        }
    }
}

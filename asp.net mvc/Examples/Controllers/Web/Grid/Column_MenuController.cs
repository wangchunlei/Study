using System.Web.Mvc;
using Domas.Web.Mvc.UI;
using Domas.Web.Mvc.Extensions;

namespace Domas.Web.Mvc.Examples.Controllers
{
    public partial class GridController : Controller
    {        
        public ActionResult Column_Menu()
        {
            return View();
        }

        public ActionResult ColumnMenu_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(GetOrders().ToDataSourceResult(request));
        }
    }
}
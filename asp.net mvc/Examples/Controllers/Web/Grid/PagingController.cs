using System.Web.Mvc;
using Domas.Web.Mvc.Examples.Models;
using Domas.Web.Mvc.Extensions;
using Domas.Web.Mvc.UI;

namespace Domas.Web.Mvc.Examples.Controllers
{
    public partial class GridController : Controller
    {
        public ActionResult Paging()
        {
            return View(new PagerViewModel());
        }

        [HttpPost]
        public ActionResult Paging(PagerViewModel pager)
        {
            return View(pager);
        }

        [HttpPost]
        public ActionResult Paging_Orders([DataSourceRequest] DataSourceRequest request)
        {
            return Json(GetOrders().ToDataSourceResult(request));
        }
    }
}
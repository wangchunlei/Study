using System.Web.Mvc;
using Domas.Web.Mvc.Examples.Models;

namespace Domas.Web.Mvc.Examples.Controllers
{
    public partial class GridController : Controller
    {
        public ActionResult ServerBinding()
        {
            return View(new NorthwindDataContext().Products);
        }
    }
}

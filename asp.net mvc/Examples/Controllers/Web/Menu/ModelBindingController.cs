using Domas.Web.Mvc.Examples.Models;
using System.Web.Mvc;
using System.Linq;

namespace Domas.Web.Mvc.Examples.Controllers
{
    public partial class MenuController : Controller
    {
        public ActionResult ModelBinding()
        {
            NorthwindDataContext northwind = new NorthwindDataContext();
            return View(northwind.Categories);
        }
    }
}

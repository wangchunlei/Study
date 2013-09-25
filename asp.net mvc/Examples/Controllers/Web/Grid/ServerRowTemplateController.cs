using System.Web.Mvc;
using System.Linq;
using Domas.Web.Mvc.Examples.Models;

namespace Domas.Web.Mvc.Examples.Controllers
{
    public partial class GridController : Controller
    {
        public ActionResult ServerRowTemplate()
        {
            return View(new NorthwindDataContext().Customers);
        }
    }
}

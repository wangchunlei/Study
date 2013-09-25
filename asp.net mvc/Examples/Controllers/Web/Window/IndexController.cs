using System.Web.Mvc;

namespace Domas.Web.Mvc.Examples.Controllers
{
    public partial class WindowController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
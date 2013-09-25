using Domas.Web.Mvc.Examples.Models;
using System.Web.Mvc;

namespace Domas.Web.Mvc.Examples.Controllers
{
    public partial class ListViewController : Controller
    {
        public ActionResult Navigation()
        {
            return View(SessionProductRepository.All());
        }
    }
}
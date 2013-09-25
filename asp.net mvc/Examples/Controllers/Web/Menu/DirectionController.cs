using System;
using System.Linq;
using System.Web.Mvc;
using Domas.Web.Mvc.UI;

namespace Domas.Web.Mvc.Examples.Controllers
{
    public partial class MenuController : Controller
    {
        public ActionResult Direction(int? direction)
        {
            direction = direction ?? 0;

            return View((MenuDirection)direction);
        }
    }
}

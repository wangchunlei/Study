using System;
using System.Linq;
using System.Web.Mvc;
using Domas.Web.Mvc.UI;

namespace Domas.Web.Mvc.Examples.Controllers
{
    public partial class MenuController : Controller
    {
        public ActionResult Orientation(string orientation)
        {
            MenuOrientation value = MenuOrientation.Horizontal;

            if (orientation == "vertical")
            {
                value = MenuOrientation.Vertical;
            }

            return View(value);
        }
    }
}

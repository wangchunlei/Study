using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web.Mvc;

namespace Domas.Web.Mvc.Examples.Controllers
{
    public partial class EditorController : Controller
    {
        public ActionResult Globalization(string culture)
        {
            Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture ?? "en-US");
            return View();
        }
    }
}
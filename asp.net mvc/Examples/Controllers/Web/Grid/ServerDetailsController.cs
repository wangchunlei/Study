using System.Web.Mvc;
using Domas.Web.Mvc.Examples.Models;

namespace Domas.Web.Mvc.Examples.Controllers
{
    public partial class GridController : Controller
    {        
        public ActionResult ServerDetails()
        {
            return View(new NorthwindDataContext().Employees);
        }
    }
}
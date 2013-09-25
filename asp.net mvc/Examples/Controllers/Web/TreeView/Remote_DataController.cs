using System.Web.Mvc;
using System.Linq;
using Domas.Web.Mvc.Examples.Models;

namespace Domas.Web.Mvc.Examples.Controllers
{
    public partial class TreeViewController : Controller
    {
        public ActionResult Remote_Data()
        {
            return View();
        }

        public JsonResult Employees(int? id)
        {
            var dataContext = new NorthwindDataContext();

            var employees = from e in dataContext.Employees
                            where (id.HasValue ? e.ReportsTo == id : e.ReportsTo == null)
                            select new {
                                id = e.EmployeeID,
                                Name = e.FirstName + " " + e.LastName,
                                hasChildren = e.Employees.Any()
                            };

            return Json(employees, JsonRequestBehavior.AllowGet);
        }
    }
}
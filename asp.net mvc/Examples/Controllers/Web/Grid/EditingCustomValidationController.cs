using System.Web.Mvc;
using Domas.Web.Mvc.Examples.Models;
using Domas.Web.Mvc.Extensions;
using Domas.Web.Mvc.UI;
using System.Linq;

namespace Domas.Web.Mvc.Examples.Controllers
{
    public partial class GridController : Controller
    {
        public ActionResult EditingCustomValidation()
        {
            return View();
        }

        public ActionResult EditingCustomValidation_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(SessionProductRepository.All()
                .Select(p => new CustomValidationProductViewModel {
                    ProductID = p.ProductID,
                    ProductName = p.ProductName,
                    UnitPrice = p.UnitPrice
                }).ToDataSourceResult(request)
            );
        }       

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult EditingCustomValidation_Update([DataSourceRequest] DataSourceRequest request, CustomValidationProductViewModel product)
        {
            if (product != null && ModelState.IsValid)
            {                
                var target = SessionProductRepository.One(p => p.ProductID == product.ProductID);
                if (target != null)
                {
                    target.ProductName = product.ProductName;
                    target.UnitPrice = product.UnitPrice;
                    SessionProductRepository.Update(target);
                }             
            }            

            return Json(new[]{product}.ToDataSourceResult(request,ModelState));
        }        
    }
}

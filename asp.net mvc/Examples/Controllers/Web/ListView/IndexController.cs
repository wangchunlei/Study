using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web.Mvc;
using Domas.Web.Mvc.Examples.Models;
using Domas.Web.Mvc.Extensions;
using Domas.Web.Mvc.UI;
using System;

namespace Domas.Web.Mvc.Examples.Controllers
{
    public partial class ListViewController : Controller
    {
        public ActionResult Index()
        {
            return View(GetProducts());
        }
                                      
        public ActionResult Products_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(GetProducts().ToDataSourceResult(request));
        }

        private static IEnumerable<ProductViewModel> GetProducts()
        {
            var northwind = new NorthwindDataContext();

            return northwind.Products.Select(product => new ProductViewModel
            {
                ProductID = product.ProductID,
                ProductName = product.ProductName,
                UnitPrice = product.UnitPrice ?? 0,
                UnitsInStock = product.UnitsInStock ?? 0,
                UnitsOnOrder = product.UnitsOnOrder ?? 0,
                Discontinued = product.Discontinued,
                LastSupply = DateTime.Today
            });
        }
    }
}
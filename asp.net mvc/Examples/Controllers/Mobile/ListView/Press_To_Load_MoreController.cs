using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Domas.Web.Mvc.UI;
using Domas.Web.Mvc.Extensions;
using Domas.Web.Mvc.Examples.Models;

namespace Domas.Web.Mvc.Examples.Controllers.Mobile
{
    public partial class ListViewController : Controller
    {       
        public ActionResult Press_To_Load_More()
        {
            return View();
        }      
    }
}

namespace Domas.Web.Mvc.Examples.Controllers
{
    using System.Web.Mvc;
    using Domas.Web.Mvc.UI;
    using Domas.Web.Mvc.Extensions;
    using Domas.Web.Mvc.Examples.Models.Scheduler;

    public partial class SchedulerController
    {
        public ActionResult Selection()
        {
            return View();
        }
    }
}

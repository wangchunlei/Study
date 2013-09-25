namespace Domas.Web.Mvc.Examples.Controllers
{
    using System.Web.Mvc;
    using Domas.Web.Mvc.UI;
    using Domas.Web.Mvc.Extensions;
    using Domas.Web.Mvc.Examples.Models.Scheduler;
    using System.Threading;
    using System.Globalization;

    public partial class SchedulerController
    {
        protected override void Execute(System.Web.Routing.RequestContext requestContext)
        {
            //if (!string.IsNullOrEmpty(requestContext.HttpContext.Request["culture"]))
            //{
            //    Thread.CurrentThread.CurrentCulture = Thread.CurrentThread.CurrentUICulture = new CultureInfo("zh-CN");
            //}
            base.Execute(requestContext);
        }

        public ActionResult Globalization()
        {
            return View();
        }
    }
}

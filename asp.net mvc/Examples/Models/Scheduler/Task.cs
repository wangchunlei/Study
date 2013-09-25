namespace Domas.Web.Mvc.Examples.Models.Scheduler
{
    using Domas.Web.Mvc.UI;
    using System.Data;

    public partial class Task : ISchedulerEvent
    {
        private new EntityKey EntityKey { get; set; }

        private new EntityState EntityState { get; set; }
    }
}
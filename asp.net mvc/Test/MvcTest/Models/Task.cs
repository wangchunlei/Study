using Domas.Web.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace MvcTest.Models
{
    public class Task : ISchedulerEvent
    {
        private new EntityKey EntityKey { get; set; }
        private new EntityState EntityState { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public bool IsAllDay { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public string RecurrenceRule { get; set; }

        public string RecurrenceException { get; set; }
    }
}
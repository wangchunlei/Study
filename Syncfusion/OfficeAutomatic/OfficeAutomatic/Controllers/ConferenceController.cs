using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OfficeAutomatic.Models;
using Syncfusion.Mvc.Grid;

namespace OfficeAutomatic.Controllers
{
    [Authorize]
    public class ConferenceController : Controller
    {
        //
        // GET: /Conference/

        public ActionResult Index()
        {
            return View();
        }
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Index(PagingParams args, FilterBarMode? Mode, bool? ShowStatusBar)
        {
            IList<Conference> conferences = null;
            using (var context = new OfficeContext())
            {
                conferences = context.Conferences.ToList();
            }

            return conferences.GridJSONActions<Conference>();
        }
        public ActionResult JSONAdd(Conference conference)
        {
            IList<Conference> conferences = null;
            using (var context = new OfficeContext())
            {
                context.Conferences.Add(conference);
                context.SaveChanges();
                conferences = context.Conferences.ToList();
            }
            return conferences.GridJSONActions<Conference>();
        }
    }
}

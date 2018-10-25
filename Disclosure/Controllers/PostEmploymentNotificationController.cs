using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Disclosure.Models;
using static Disclosure.Models.ViewPostEmploymentNotification;

namespace Disclosure.Controllers
{
    public class PostEmploymentNotificationController : Controller
    {
        // GET: PostEmploymentNotification
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> ViewReport()
        {
            return PartialView(ViewPostEmploymentNotification.GetMockData());
        }

        public async Task<ActionResult> ViewSearch()
        {
            var reports = ViewPostEmploymentNotification.GetMockData();
            return PartialView(reports);
        }

        public async Task<ActionResult> ViewSearchResult(ViewPostEmploymentNotification.Filter filter)
        {
            new List<PostEmploymentData>()
            {

            };
            return PartialView();
        }
    }
}
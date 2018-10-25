using Disclosure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using static Disclosure.Models.ViewGiftTravelFilings;

namespace Disclosure.Controllers
{
    public class GiftTravelFilingsController : Controller
    {
        // GET: GIftTravelFilings
        public ActionResult Index()
        {
            return View();
        }

      
        public async Task<ActionResult> ViewReport()
        {
            return PartialView(ViewGiftTravelFilings.GetMockData());
        }

        public async Task<ActionResult> ViewSearch()
        {
            var reports = ViewGiftTravelFilings.GetMockData();
            return PartialView(reports);
        }

        public async Task<ActionResult> ViewSearchResult(ViewGiftTravelFilings.Filter filter)
        {
            new List<TravelData>()
            {

            };
            return PartialView();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Disclosure.Models;
using static Disclosure.Models.ViewForeignTravelReports;

namespace Disclosure.Controllers
{
    public class ForeignTravelController : Controller
    {
        // GET: ForeignTravel
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> ViewReport()
        {
            List<int> years = new List<int>();
            for (var i = 1994; i < DateTime.Now.Year; i++)
            {
                years.Add(i);
            }
            ViewBag.Years = new SelectList(years);
            ViewBag.Quarters = new SelectList(new List<string> {
                "First Quarter","Second Quarter","Third Quarter","Fourth Quarter"
            });

            return PartialView(ViewForeignTravelReports.GetMockData());
        }

        public async Task<ActionResult> ViewSearchResult(ViewForeignTravelReports.Filter filter)
        {
            ViewBag.Quarter = filter.Quarter;
            ViewBag.Year = filter.Year;
            return PartialView(new List<TravelReport>()
            {

            });
        }
    }
}
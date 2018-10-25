using Disclosure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using static Disclosure.Models.ViewFinancialDisclosureReports;

namespace Disclosure.Controllers
{
    public class FinancialDisclosureController : AsyncController
    {
        // GET: FinancialDisclosure
        public async Task<ActionResult> IndexAsync()
        {
            return View();
        }

        public async Task<ActionResult> ViewReport()
        {
            return PartialView(ViewFinancialDisclosureReports.GetMockData());
        }

        public async Task<ActionResult> ViewSearch()
        {
            ViewBag.States = new SelectList(UsStates.GetAllStates(), "State", "State");
            var reports = ViewFinancialDisclosureReports.GetMockData();
            ViewBag.ElectionYears = new SelectList(reports.Reports, "Year", "Year");
            return PartialView(reports);
        }

        public async Task<ActionResult> ViewSearchResult(ViewFinancialDisclosureReports.Filter filter)
        {
            new List<FinancialDisclosureData>()
            {

            };
            return PartialView();
        }
    }
}
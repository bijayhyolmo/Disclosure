using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Disclosure.Controllers
{
    public class DisclosureController : AsyncController
    {
        // GET: Disclosure
        public async Task<ActionResult> IndexAsync()
        {
            return View();
        }

        public async Task<ActionResult> FinancialDisclosureAsync()
        {
            return View();
        }

        public async Task<ActionResult> ViewFinancialDisclosureReports()
        {
            return PartialView();
        }

        public async Task<ActionResult> ViewFinancialDisclosureSearch()
        {
            return PartialView();
        }

        public async Task<ActionResult> ForeignTravExpAsync()
        {
            return View();
        }

        public async Task<ActionResult> FrankedMaterials()
        {
            return View();
        }

        public async Task<ActionResult> GiftTravelFilings()
        {
            return View();
        }
    }
}
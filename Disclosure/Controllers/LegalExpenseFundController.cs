using Disclosure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Disclosure.Controllers
{
    public class LegalExpenseFundController : AsyncController
    {
        // GET: LegalExpenseFund
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewReport()
        {
            return PartialView(ViewLegalExpenseFund.GetMockData());
        }
    }
}
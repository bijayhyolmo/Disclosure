using Disclosure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Disclosure.Controllers
{
    public class OfficeOfCongressionalEthicsController : Controller
    {
        // GET: OfficeOfCongressionalEthics
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewReport()
        {
            return PartialView(ViewOfficeOfCongressionalEthics.GetMockData());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JoeCodeMvcOracleExample.UI.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var viewModel = new Models.Home.Index();
            //viewModel.OracleRecordCount = 0;
            //viewModel.Flights = new List<Models.Home.Index.Flight>();

            using (var context = new ResourceAccess.Contexts.Model1()) {
                viewModel.OracleRecordCount = context.IRCS_ARR_FLT_CODESHARE.Count();
                viewModel.Flights =context.IRCS_ARR_FLT_CODESHARE
                    .Select(s=>new Models.Home.Index.Flight { 
                        FlightNbr = s.IRCS_FLT_NBR,
                        FlightArrStn = s.IRCS_FLT_ARR_STN
                    }).ToList();
            }
            return View(viewModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult NewPage()
        {
            ViewBag.Message = "Your New page.";

            return View();
        }
    }
}
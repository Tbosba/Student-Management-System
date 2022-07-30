using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestingProject.Controllers
{
   
    public class HomeController : Controller
    {

        
        private static string ApiKey = "AIzaSyDIEtRLmFHKfgq6bnmuWtDOtVHb99lmWto";
        private static string AuthEmail = "";
        private static string AuthPassword = "";
        private static string Bucket = "gs://asp-mvc-with-android-dd994.appspot.com";


        public ActionResult Index1()
        {
            return View();
        }


        [Authorize]
        public ActionResult Index()
        {
            return View();
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

    }
}
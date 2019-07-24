using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BRK.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Lander()
        {
            ViewBag.Message = "Let's land on the moon!";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Who is Rebecca V. Gardner?";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "How to contact Rebecca";

            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToolsForPersonalProcessImprovement.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string accountUser = null;
            if (accountUser == null)
            {
                return RedirectToAction("login", "Home");
            }
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

        public ActionResult Login()
        {
            ViewBag.Message = "login page.";

            return View();
        }
    }
}
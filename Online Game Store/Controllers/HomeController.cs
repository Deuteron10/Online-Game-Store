using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Online_Game_Store.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your customers (about) page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your games (contact) page.";
            

            return View();
        }
    }
}
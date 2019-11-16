using Meteo.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Meteo.Controllers
{
    public class HomeController : Controller
    {
        private PomiaryContext db = new PomiaryContext();
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "";

            return View();
        }
    }
}
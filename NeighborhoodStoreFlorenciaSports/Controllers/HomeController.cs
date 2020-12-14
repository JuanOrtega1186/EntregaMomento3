using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NeighborhoodStoreFlorenciaSports.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "INFORMACION IMPORTANTE";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Comunicate con nosotros.";

            return View();
        }
    }
}
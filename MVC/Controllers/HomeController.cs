using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models.DAL;
using MVC.Models.WebServices;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {



            var messages = new SR().GetMessages();


            var _context = new _1dv449_aa223ig_Mashup();

            //_context.(new Models.Message());

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
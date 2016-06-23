using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models.DAL;
using MVC.Models.WebServices;
using MVC.Models.Services;

namespace MVC.Controllers
{
    public class MessageController : Controller
    {


        public ActionResult Index()
        {
            var refreshService = new TrafficMessageService();

            var messages = refreshService.RefreshTrafficMessage();
   
            return View(messages);
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
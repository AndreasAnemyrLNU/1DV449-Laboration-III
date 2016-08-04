using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models.DAL;
using MVC.Models.WebServices;
using MVC.Models.Services;
using MVC.Models;

namespace MVC.Controllers
{

    public class MessageController : Controller
    {
        private TrafficMessageService refreshService = new TrafficMessageService();

        public ActionResult Index()
        {
            var model = new IndexViewModel();

            UpdateModel(model);
            model.Messages = refreshService.RefreshTrafficMessage(model.Cat);

            return View(model);
        }

        public ActionResult ReCache(IndexViewModel model)
        {
            //User cklicked update cache now!
            refreshService.RefreshTrafficMessage(model.Cat, true);
            return RedirectToAction("index", model);
        }

    }
}
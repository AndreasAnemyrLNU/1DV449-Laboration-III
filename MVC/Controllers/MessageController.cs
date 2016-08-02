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
        public ActionResult Index()
        {
            var model = new IndexViewModel();

            UpdateModel(model);

            var refreshService = new TrafficMessageService();

            model.Messages = refreshService.RefreshTrafficMessage(model.Cat);

            return View(model);
        }
    }
}
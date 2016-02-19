﻿using System.Web.Mvc;
using System.Web.Services.Description;
using EpamInternetProvider.Controllers;

namespace EpamInternetProvider.Areas.Common.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index(string message = "")
        {
            ViewBag.Msg = message;
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

        public ActionResult SeeServicesList()
        {
            var services = db.ServiceDb.GetAll();
            return View(services);
        }

        public ActionResult SeeServiceDetails(int id)
        {
            var service = db.ServiceDb.GetById(id);
            return View(service);
        }

        public ActionResult SeeRateList()
        {
            var rates = db.RateDb.GetAll();
            return View(rates);
        }

        public ActionResult SeeRateDetails(int id)
        {
            var rate = db.RateDb.GetById(id);
            return View(rate);
        }
    }
}
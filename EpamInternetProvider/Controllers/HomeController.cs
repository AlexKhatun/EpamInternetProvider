using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BOL;
using BOL.Models;
using DAL;

namespace EpamInternetProvider.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            InternetProviderContext db = new InternetProviderContext();
            db.Role.Add(new Role() {Title = "blabla"});
            db.SaveChanges();
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
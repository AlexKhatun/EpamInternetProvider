using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BOL.Models;
using EpamInternetProvider.Controllers;

namespace EpamInternetProvider.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : BaseController
    {
        public ActionResult Adminka(string message = "")
        {
            ViewBag.Msg = message;
            return View();
        }

        public ActionResult SeeListUnregUsers()
        {
            return View("ListUnregUsers", db.UserDb.GetAll().Where(x => x.IsRegister == false));
        }

        public ActionResult RegisterUser(int id)
        {
            var user = db.UserDb.GetById(id);
            user.IsRegister = true;
            db.UserDb.Update(user);
            return RedirectToAction("SeeListUnregUsers");
        }

        public ActionResult AddService()
        {
            SelectList serviceTypes = new SelectList(db.ServiceTypeDb.GetAll(), "ServiceTypeId", "Title");
            ViewBag.ServiceTypes = serviceTypes;
            return View();
        }

        [HttpPost]
        public ActionResult AddService(Service service)
        {
            var result = db.ServiceDb.Insert(service);
            if (result)
            {
                return RedirectToAction("Adminka", new {message = "Услуга добавлена"});
            }
            else
            {
                return RedirectToAction("Adminka", new {message = "Оишбка"});
            }
        }

        public ActionResult AddRate()
        {
            SelectList services = new SelectList(db.ServiceDb.GetAll(), "ServiceId", "Title");
            ViewBag.Services = services;
            return View();
        }

        [HttpPost]
        public ActionResult AddRate(Rate rate)
        {
            var result = db.RateDb.Insert(rate);
            if (result)
            {
                return RedirectToAction("Adminka", new { message = "Тариф добавлен" });
            }
            else
            {
                return RedirectToAction("Adminka", new { message = "Оишбка" });
            }
        }
    }
}
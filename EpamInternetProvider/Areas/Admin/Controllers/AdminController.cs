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

        public ActionResult AddService(string message = "")
        {
            SelectList serviceTypes = new SelectList(db.ServiceTypeDb.GetAll(), "ServiceTypeId", "Title");
            ViewBag.Msg = message;
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

        public ActionResult EditService(int id)
        {
            var service = db.ServiceDb.GetById(id);
            SelectList serviceTypes = new SelectList(db.ServiceTypeDb.GetAll(), "ServiceTypeId", "Title");
            ViewBag.ServiceTypes = serviceTypes;
            return View(service);
        }

        [HttpPost]
        public ActionResult EditService(Service service)
        {
            var result = db.ServiceDb.Update(service);
            if (result)
            {

                return RedirectToAction("Adminka", new {message = "Сохранения изменены"});
            }
            else
            {
                return RedirectToAction("Adminka", new {message = "Оишбка"});
            }
        }

        public ActionResult DeleteService(int id)
        {
            var result = db.ServiceDb.Delete(id);
            if(result)
            {

                return RedirectToAction("Adminka", new { message = "Услуга удалена" });
            }
            else
            {
                return RedirectToAction("Adminka", new { message = "Оишбка" });
            }
        }

        public ActionResult AddRate(string message = "")
        {
            SelectList services = new SelectList(db.ServiceDb.GetAll(), "ServiceId", "Title");
            ViewBag.Msg = message;
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

        public ActionResult EditRate(int id)
        {
            var rate = db.RateDb.GetById(id);
            SelectList services = new SelectList(db.ServiceDb.GetAll(), "ServiceId", "Title");
            ViewBag.Services = services;
            return View(rate);
        }

        [HttpPost]
        public ActionResult EditRate(Rate rate)
        {
            var result = db.RateDb.Update(rate);
            if (result)
            {

                return RedirectToAction("Adminka", new { message = "Сохранения изменены" });
            }
            else
            {
                return RedirectToAction("Adminka", new { message = "Оишбка" });
            }
        }

        public ActionResult DeleteRate(int id)
        {
            var result = db.RateDb.Delete(id);
            if (result)
            {

                return RedirectToAction("Adminka", new { message = "Тариф удален" });
            }
            else
            {
                return RedirectToAction("Adminka", new { message = "Оишбка" });
            }
        }
    }
}
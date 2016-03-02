using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BOL.Models;
using EpamInternetProvider.Controllers;

namespace EpamInternetProvider.Areas.Users.Controllers
{
    [Authorize]
    public class UserController : BaseController
    {
        public ActionResult EditProfile(string message = "")
        {
            var user = db.UserDb.GetAll().First(x => x.Email == HttpContext.User.Identity.Name);
            if (user.Role.Title == "Blocked")
            {
                ViewBag.Blocked = "Пополните счет!";
            }
            else
            {
                ViewBag.Blocked = "";
            }
            return View("PersonalArea", user);
        }

        [HttpPost]
        public ActionResult EditProfile(User user)
        {
            db.UserDb.Update(user);
            return RedirectToAction("EditProfile");
        }

        public ActionResult AddPurse(string message = "")
        {
            ViewBag.Msg = message;
            return View();
        }

        [HttpPost]
        public ActionResult AddPurse(Purse purse)
        {
            purse.UserId = db.UserDb.GetAll().First(x => x.Email == User.Identity.Name).UserId;
            db.PurseDb.Insert(purse);
            return RedirectToAction("EditProfile", new {message = "Кошелек успешно добавлен"});
        }

        public ActionResult EditPurse(string message = "")
        {
            ViewBag.Msg = message;
            var purse = db.PurseDb.GetAll().First(x => x.User.Email == User.Identity.Name);
            return View(purse);
        }

        [HttpPost]
        public ActionResult EditPurse(Purse purse)
        {
            purse.UserId = db.PurseDb.GetById(purse.PurseId).UserId;
            purse.Money = db.PurseDb.GetById(purse.PurseId).Money;
            db.PurseDb.Update(purse);
            return RedirectToAction("EditProfile");
        }

        public ActionResult AddAdress(string message = "")
        {
            ViewBag.Msg = message;
            return View();
        }

        [HttpPost]
        public ActionResult AddAdress(Adress adress)
        {
            adress.UserId = db.UserDb.GetAll().First(x => x.Email == User.Identity.Name).UserId;
            db.AdressDb.Insert(adress);
            return RedirectToAction("EditProfile", new {message = "Адрес записан"});
        }

        public ActionResult EditAdress(string message = "")
        {
            ViewBag.Msg = message;
            var adress = db.AdressDb.GetAll().First(x => x.User.Email == User.Identity.Name);
            return View(adress);
        }

        [HttpPost]
        public ActionResult EditAdress(Adress adress)
        {
            adress.UserId = db.AdressDb.GetById(adress.AdressId).UserId;
            db.AdressDb.Update(adress);
            return RedirectToAction("EditProfile");
        }

        public ActionResult AddFunse(string message = "")
        {
            ViewBag.Msg = message;
            return View();
        }

        [HttpPost]
        public ActionResult AddFunse(Purse purse)
        {
            var currentPurse = db.PurseDb.GetAll().First(x => x.User.Email == User.Identity.Name);
            currentPurse.Money += purse.Money;
            db.PurseDb.Update(currentPurse);
            return RedirectToAction("EditProfile");
        }
    }
}
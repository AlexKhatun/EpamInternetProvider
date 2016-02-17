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
            return View("PersonalArea", user);
        }

        public ActionResult AddPurse()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddPurse(Purse purse)
        {
            purse.UserId = db.UserDb.GetAll().First(x => x.Email == User.Identity.Name).UserId;
            db.PurseDb.Insert(purse);
            return RedirectToAction("EditProfile", new {message = "Кошелек успешно добавлен"});
        }

        public ActionResult AddAdress()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAdress(Adress adress)
        {
            adress.UserId = db.UserDb.GetAll().First(x => x.Email == User.Identity.Name).UserId;
            db.AdressDb.Insert(adress);
            return RedirectToAction("EditProfile", new { message = "Адрес записан" });
        }
    }
}
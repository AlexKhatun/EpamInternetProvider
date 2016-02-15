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
        public ActionResult EditProfile()
        {
            var user = db.UserDb.GetAll().First(x => x.Email == HttpContext.User.Identity.Name);
            return View("PersonalArea", user);
        }

        public ActionResult AddPurse()
        {
            return View();
        }

        public ActionResult AddPurse(Purse purse)
        {
            purse.UserId = db.UserDb.GetAll().First(x => x.Email == User.Identity.Name).UserId;
            db.PurseDb.Insert(purse);
            return View();
        }
    }
}
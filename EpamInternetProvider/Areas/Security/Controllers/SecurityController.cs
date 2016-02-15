using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using BOL.Models;
using EpamInternetProvider.Controllers;


namespace EpamInternetProvider.Areas.Security.Controllers
{
    public class SecurityController : BaseController
    {
        // GET: Security/Security
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            if (Membership.ValidateUser(user.Email, user.Password))
            {
                FormsAuthentication.SetAuthCookie(user.Email, true);
            }
            return RedirectToAction("Index", "Home", new {area = "Common"});
        }

        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registration(User user)
        {
            try
            {
                db.UserDb.Insert(user);
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Home", new { area = "Common" });
            }
            FormsAuthentication.SetAuthCookie(user.Email, true);
            return RedirectToAction("Index", "Home", new { area = "Common" });
        }
    }
}
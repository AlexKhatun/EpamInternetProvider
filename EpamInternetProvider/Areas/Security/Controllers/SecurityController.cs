﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.Services.Description;
using BOL.Models;
using EpamInternetProvider.Controllers;


namespace EpamInternetProvider.Areas.Security.Controllers
{
    public class SecurityController : BaseController
    {
        // GET: Security/Security
        public ActionResult Login(string message = "")
        {
            ViewBag.Msg = message;
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            user.Email = user.Email.ToLower();
            if (Membership.ValidateUser(user.Email, user.Password) && db.UserDb.GetAll().First(x=>x.Email == user.Email).IsRegister)
            {
                FormsAuthentication.SetAuthCookie(user.Email, true);
                return RedirectToAction("Index", "Home", new { area = "Common" , message = "Вы успешно вошли в систему!"});
            }
            return RedirectToAction("Login", "Security", new {area = "Security", message = "Оишбка входа!"});
        }

        public ActionResult Registration(string message = "")
        {
            ViewBag.Msg = message;
            return View();
        }

        [HttpPost]
        public ActionResult Registration(User user)
        {
            try
            {
                user.Email = user.Email.ToLower();
                ViewBag.Msg = db.UserDb.Insert(user);
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Home", new { area = "Common", message = ViewBag.Msg });
            }
            return RedirectToAction("Index", "Home", new { area = "Common", message = ViewBag.Msg});
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home", new {area = "Common", message = "Вы вышли из системы"});
        }
    }
}
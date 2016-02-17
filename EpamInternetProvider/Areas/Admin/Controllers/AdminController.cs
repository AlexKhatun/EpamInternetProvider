using System;
using System.Collections.Generic;
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
        public ActionResult Adminka()
        {
            return View();
        }

        public ActionResult SeeListUnregUsers()
        {
            return View("ListUnregUsers", db.UserDb.GetAll().Where(x=>x.IsRegister == false));
        }

        public ActionResult RegisterUser(int id)
        {
            var user = db.UserDb.GetById(id);
            user.IsRegister = true;
            db.UserDb.Update(user);
            return RedirectToAction("SeeListUnregUsers");
        }
    }
}
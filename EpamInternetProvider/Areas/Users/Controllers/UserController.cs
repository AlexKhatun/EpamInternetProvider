using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EpamInternetProvider.Controllers;

namespace EpamInternetProvider.Areas.Users.Controllers
{
    public class UserController : BaseController
    {
        public ActionResult OpenPersonalArea()
        {
            var user = db.UserDb.GetAll().First(x => x.Email == HttpContext.User.Identity.Name);
            return View("PersonalArea", user);
        }
    }
}
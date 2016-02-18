using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.DbLogic;
using BOL.Models;

namespace EpamInternetProvider.Controllers
{
    public class StartController : BaseController
    {
        // GET: Start
        public ActionResult Index()
        {
            //var r = db.RoleDb.GetById(1);
            //db.UserDb.Insert(new User { FirstName = "Alex", LastName = "Khatuntsev", Password = "Aleksey96", IsDeleted = false, Email = "Khatun3000@gmail.com", IsRegister = false, RegisterDate = DateTime.Now, RoleId = r.RoleId });
            return RedirectToAction("Index", "Home", new {area = "Common"});
        }
    }
}
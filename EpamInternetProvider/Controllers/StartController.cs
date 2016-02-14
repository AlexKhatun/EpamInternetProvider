using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.DbLogic;
using BOL.Models;

namespace EpamInternetProvider.Controllers
{
    public class StartController : Controller
    {
        // GET: Start
        public ActionResult Index()
        {
            AllDb db = new AllDb();
            var r = db.RoleDb.GetById(1);
            db.UserDb.Insert(new User { FirstName = "fdsa", LastName = "dasda", Password = "MyPass", IsDeleted = false, Email = "Khatunec@gmail.com", RegisterDate = DateTime.Now, RoleId = r.RoleId});
            return RedirectToAction("Index", "Home", new {area = "Common"});
        }
    }
}
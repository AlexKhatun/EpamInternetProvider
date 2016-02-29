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
    public class SubscribeController : BaseController
    {
        public ActionResult SeeSubscribeList(string message = "")
        {
            ViewBag.Msg = message;
            var subscribes = db.SubscribeDb.GetAll().Where(x => x.User.Email == User.Identity.Name);
            return View(subscribes);
        }

        [HttpPost]
        public ActionResult AddSubscribe(Rate rate)
        {
            Subscribe subscribe = new Subscribe
            {
                RateId = rate.RateId,
                SubscribeDate = DateTime.Now,
                UserId = db.UserDb.GetAll().First(x => x.Email == User.Identity.Name).UserId
            };
            db.SubscribeDb.Insert(subscribe);
            return RedirectToAction("SeeRateList", new {area = "Common", controller = "Home"});
        }

        public ActionResult SeeSubscribeDetails(int id, string message = "")
        {
            ViewBag.Msg = message;
            var subscribe = db.SubscribeDb.GetById(id);
            return View(subscribe);
        }

        public ActionResult DeleteSubscribe(int id)
        {
            db.SubscribeDb.Delete(id);
            return RedirectToAction("SeeSubscribeList");
        }
    }
}
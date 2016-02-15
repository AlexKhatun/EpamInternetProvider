using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL.DbLogic;

namespace EpamInternetProvider.Controllers
{
    public class BaseController : Controller
    {
        protected AllDb db;

        public BaseController()
        {
            db = new AllDb();
        }

    }
}
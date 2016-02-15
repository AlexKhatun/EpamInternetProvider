using System.Web.Mvc;
using System.Web.Services.Description;

namespace EpamInternetProvider.Areas.Common.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string message = "")
        {
            ViewBag.Msg = message;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
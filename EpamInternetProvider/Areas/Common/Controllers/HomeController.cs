using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web.Services.Description;
using EpamInternetProvider.Controllers;

namespace EpamInternetProvider.Areas.Common.Controllers
{
    public class HomeController : BaseController
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

        public ActionResult SeeServicesList(string sortOrder, string sortBy, string message = "")
        {
            var services = db.ServiceDb.GetAll();
            ViewBag.Msg = message;
            ViewBag.SortBy = sortBy;
            ViewBag.SortOrder = sortOrder;
            switch (sortBy)
            {
                case "Title":
                    switch (sortOrder)
                    {
                        case "Asc":
                            services = services.OrderBy(x => x.Title).ToList();
                            break;
                        case "Desc":
                            services = services.OrderByDescending(x => x.Title).ToList();
                            break;
                        default:
                            break;
                    }
                    break;
                case "ServiceTypeTitle":
                    switch (sortOrder)
                    {
                        case "Asc":
                            services = services.OrderBy(x => x.ServiceType.Title).ToList();
                            break;
                        case "Desc":
                            services = services.OrderByDescending(x => x.ServiceType.Title).ToList();
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            //ViewBag.Pages = Math.Ceiling((double)(db.ServiceDb.GetAll().Count() / 2));
            //int myPage = int.Parse(page ?? "1");
            //ViewBag.Page = page;
            //services = services.Skip((myPage - 1) * 2).Take(2).ToList();
            return View(services);
        }

        public ActionResult SeeServiceDetails(int id, string message = "")
        {
            ViewBag.Msg = message;
            var service = db.ServiceDb.GetById(id);
            return View(service);
        }

        public ActionResult SeeRateList(string sortOrder, string sortBy, string message = "")
        {
            try
            {
                ViewBag.Purse = db.UserDb.GetAll().First(x => x.Email == User.Identity.Name).Purses.Count;
            }
            catch
            {
                ViewBag.Purse = 0;
            }
            var rates = db.RateDb.GetAll();
            ViewBag.Msg = message;
            ViewBag.SortBy = sortBy;
            ViewBag.SortOrder = sortOrder;
            switch (sortBy)
            {
                case "ServiceTitle":
                    switch (sortOrder)
                    {
                        case "Asc":
                            rates = rates.OrderBy(x => x.Service.Title).ToList();
                            break;
                        case "Desc":
                            rates = rates.OrderByDescending(x => x.Service.Title).ToList();
                            break;
                        default:
                            break;
                    }
                    break;
                case "Title":
                    switch (sortOrder)
                    {
                        case "Asc":
                            rates = rates.OrderBy(x => x.Title).ToList();
                            break;
                        case "Desc":
                            rates = rates.OrderByDescending(x => x.Title).ToList();
                            break;
                        default:
                            break;
                    }
                    break;
                case "Price":
                    switch (sortOrder)
                    {
                        case "Asc":
                            rates = rates.OrderBy(x => x.Price).ToList();
                            break;
                        case "Desc":
                            rates = rates.OrderByDescending(x => x.Title).ToList();
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            //ViewBag.Pages = Math.Ceiling((double)(db.RateDb.GetAll().Count() / 2));
            //int myPage = int.Parse(page ?? "1");
            //ViewBag.Page = page;
            //rates = rates.Skip((myPage - 1) * 2).Take(2).ToList();
            return View(rates);
        }

        public ActionResult SeeRateDetails(int id, string message = "")
        {
            ViewBag.Id = id;
            ViewBag.Msg = message;
            var rate = db.RateDb.GetById(id);
            return View(rate);
        }

        public FileResult DownloadListOfRates()
        {
            return File("C:\\Users\\Alex\\Desktop\\EpamInternetProvider\\EpamInternetProvider\\App_Data\\СписокЗадач.txt", "application/txt");
        }
    }
}
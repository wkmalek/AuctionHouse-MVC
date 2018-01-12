using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuctionHouseMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var db = new context();
            return View(db.Categories.Where(x => x.ID.Length > 0).ToList());
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

        public ActionResult TreeView()
        {
            var db = new context();
            return View(db.Categories.Where(x=>x.ID.Length > 0).ToList());
        }
    }
}
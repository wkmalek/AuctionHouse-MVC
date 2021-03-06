﻿using AuctionHouseMVC.Models;
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
            var val = db.Categories.Where(x => x.ID.Length > 0).ToList();
            ModelContainer finalModel = new ModelContainer();
            finalModel.cat = val;
            return View(finalModel);
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
            var val = db.Categories.Where(x => x.ID.Length > 0).ToList();
            ModelContainer finalModel = new ModelContainer();
            finalModel.cat = val;
            return View(finalModel);
        }
    }
}
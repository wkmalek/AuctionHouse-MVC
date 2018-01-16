using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AuctionHouseMVC.Models;

namespace AuctionHouseMVC.Controllers
{
    public class AuctionListViewModelsController : Controller, IDisposable
    {
        private AuctionListContext db;

        // GET: AuctionListViewModels
        public ActionResult Index()
        {
            SortProperties sp = new SortProperties()
            {
                id = "1",
            };
            db = new AuctionListContext(sp, Enums.paramTypeForAuctionList.byCategories);
            var AuctionList = db.AuctionListView;
            ModelContainer cont = new ModelContainer();
            cont.AddModel(AuctionList);
            return View(cont);
        }

        // GET: AuctionListViewModels/Details/5


        // GET: AuctionListViewModels/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        // POST: AuctionListViewModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Title,StartPrice,DateCreated,DataExpires,Description")] AuctionListViewModels auctionListViewModels)
        //{
        //    //if (ModelState.IsValid)
        //    //{
        //    //    db.AuctionListViewModels.Add(auctionListViewModels);
        //    //    db.SaveChanges();
        //    //    return RedirectToAction("Index");
        //    //}

        //    return View(auctionListViewModels);
        //}


        // POST: AuctionListViewModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "Title,StartPrice,DateCreated,DataExpires,Description")] AuctionListViewModels auctionListViewModels)
        //{
        //    //if (ModelState.IsValid)
        //    //{
        //    //    db.Entry(auctionListViewModels).State = EntityState.Modified;
        //    //    db.SaveChanges();
        //    //    return RedirectToAction("Index");
        //    //}
        //    return View(auctionListViewModels);
        //}



        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

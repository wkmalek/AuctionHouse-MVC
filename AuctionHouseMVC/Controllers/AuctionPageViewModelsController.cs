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
    public class AuctionPageViewModelsController : Controller
    {
        //private Auctions db = new Auctions();
        public AuctionPageContext db = new AuctionPageContext();

        // GET: AuctionPageViewModels
        public ActionResult Index()
        {
            return View(db.auctions.Where(x => x.Id == "0").FirstOrDefault());
        }

        //// GET: AuctionPageViewModels/Details/5
        //public ActionResult Details(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    AuctionPageViewModel auctionPageViewModel = db.AuctionPageViewModels.Find(id);
        //    if (auctionPageViewModel == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(auctionPageViewModel);
        //}

        //// GET: AuctionPageViewModels/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: AuctionPageViewModels/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "AuctionTitle,ActualPrice,StartingPrice,Currency,CreatorName,CreatorId,ShortDescription,LongDescription,DateCreated,DateEnd")] AuctionPageViewModel auctionPageViewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.AuctionPageViewModels.Add(auctionPageViewModel);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(auctionPageViewModel);
        //}

        //// GET: AuctionPageViewModels/Edit/5
        //public ActionResult Edit(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    AuctionPageViewModel auctionPageViewModel = db.AuctionPageViewModels.Find(id);
        //    if (auctionPageViewModel == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(auctionPageViewModel);
        //}

        //// POST: AuctionPageViewModels/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "AuctionTitle,ActualPrice,StartingPrice,Currency,CreatorName,CreatorId,ShortDescription,LongDescription,DateCreated,DateEnd")] AuctionPageViewModel auctionPageViewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(auctionPageViewModel).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(auctionPageViewModel);
        //}

        //// GET: AuctionPageViewModels/Delete/5
        //public ActionResult Delete(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    AuctionPageViewModel auctionPageViewModel = db.AuctionPageViewModels.Find(id);
        //    if (auctionPageViewModel == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(auctionPageViewModel);
        //}

        //// POST: AuctionPageViewModels/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(string id)
        //{
        //    AuctionPageViewModel auctionPageViewModel = db.AuctionPageViewModels.Find(id);
        //    db.AuctionPageViewModels.Remove(auctionPageViewModel);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

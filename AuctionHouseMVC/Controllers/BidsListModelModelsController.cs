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
    public class BidsListModelModelsController : Controller
    {
        private BidsContext db = new BidsContext();

        // GET: BidsListModelModels
        public ActionResult Index()
        {
            return View(db.BidsViewModels.ToList());
        }

        // GET: BidsListModelModels/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BidsViewModel bidsViewModel = db.BidsViewModels.Find(id);
            if (bidsViewModel == null)
            {
                return HttpNotFound();
            }
            return View(bidsViewModel);
        }

        // GET: BidsListModelModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BidsListModelModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "UserUrl,UserName,Value,bidData")] BidsViewModel bidsViewModel)
        {
            if (ModelState.IsValid)
            {
                db.BidsViewModels.Add(bidsViewModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(bidsViewModel);
        }

        // GET: BidsListModelModels/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BidsViewModel bidsViewModel = db.BidsViewModels.Find(id);
            if (bidsViewModel == null)
            {
                return HttpNotFound();
            }
            return View(bidsViewModel);
        }

        // POST: BidsListModelModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserUrl,UserName,Value,bidData")] BidsViewModel bidsViewModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bidsViewModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(bidsViewModel);
        }

        // GET: BidsListModelModels/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BidsViewModel bidsViewModel = db.BidsViewModels.Find(id);
            if (bidsViewModel == null)
            {
                return HttpNotFound();
            }
            return View(bidsViewModel);
        }

        // POST: BidsListModelModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            BidsViewModel bidsViewModel = db.BidsViewModels.Find(id);
            db.BidsViewModels.Remove(bidsViewModel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

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

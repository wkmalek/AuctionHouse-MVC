using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AuctionHouseMVC.Models;
using Microsoft.AspNet.Identity;

namespace AuctionHouseMVC.Controllers
{
    public class BidsNewViewModelsController : Controller
    {
        private BidsContext db = new BidsContext();
       
        // GET: BidsNewViewModels
        public ActionResult Index()
        {
            
            return View(db.BidsViewModels.ToList());
        }

        // GET: BidsNewViewModels/Create
        public ActionResult Create()
        {
            Bids Bid = new Bids();
            ModelContainer cont = new ModelContainer();
            cont.AddModel(Bid);
            
            return View(cont);
        }

        // POST: BidsNewViewModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "Value")] Bids bid, string id)
        { 
            if (ModelState.IsValid)
            {

                Bids Bid = new Bids
                {
                    AuctionId = id,
                    UserId = User.Identity.GetUserId(),
                    Id = Guid.NewGuid().ToString(),
                    Value = bid.Value,
                    BidDate = DateTime.Now,        
                };
                db.bids.Add(Bid);
                
                db.SaveChanges();
                return Redirect("~/AuctionPageViewModel/" + bid.AuctionId);
            }
            
            return Redirect("/");
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

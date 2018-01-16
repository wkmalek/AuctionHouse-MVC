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
    public class AuctionPageViewModelsController : Controller
    {
        //private Auctions db = new Auctions();
        public AuctionPageContext db = new AuctionPageContext();

        // GET: AuctionPageViewModels
        public ActionResult Index(string id)
        {   
                //db = new AuctionPageContext();
                var it = db.auctions.auctions.Where(x => x.Id == id).FirstOrDefault();
                var vm = new AuctionPageViewModel(it);
                ModelContainer cont = new ModelContainer();
                cont.AddModel(vm);
                return View(cont); 
        }

        // GET: BidsNewViewModels/Create
        public ActionResult Create()
        {
            Auctions auction = new Auctions();
            ModelContainer cont = new ModelContainer();
            cont.AddModel(auction);

            return View(cont);
        }

        // POST: BidsNewViewModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        public ActionResult Create([Bind(Include = "AuctionTitle, PriceStart, DescriptionShort, DescriptionLong")] CreateAuctionViewModel auc)
        {
            if (ModelState.IsValid)
            {
                Auctions auction = new Auctions()
                {
                    Id = Guid.NewGuid().ToString(),
                    CategoryId = "1",
                    Title = auc.AuctionTitle,
                    StartPrice = auc.PriceStart,
                    Currency = "USD",
                    CreatorId = User.Identity.GetUserId(),
                    ShortDescription = auc.DescriptionShort,
                    LongDescription = auc.DescriptionLong,
                    DateCreated = DateTime.Now,
                    //ExpiresIn = (int)auc.ExpiresIn.,
                    
                };

                db.auctions.auctions.Add(auction);

                db.auctions.SaveChanges();
                return Redirect("~/AuctionPageViewModels/Index/" + auction.Id);
            }

            return Redirect("/");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.auctions.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

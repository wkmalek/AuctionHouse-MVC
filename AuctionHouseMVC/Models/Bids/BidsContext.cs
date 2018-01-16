using AuctionHouseMVC.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AuctionHouseMVC.Models
{
    public class BidsContext : DbContext
    {
        public DbSet<Bids> bids { get; set; }

        public List<Bids> ReturnSelectedAuction(string id, paramTypeForCategory type)
        {
            switch (type)
            {
                case paramTypeForCategory.byId:
                    return bids.Where(x => x.Id == id).ToList();
                case paramTypeForCategory.byUserId:
                    return bids.Where(x => x.UserId == id).ToList();
                case paramTypeForCategory.byAuctionId:
                    return bids.Where(x => x.AuctionId == id).ToList(); 
                
                default:
                    return bids.Where(x => x.Id == id).ToList();
            }
        }

        private List<string> ReturnIdOfHighestBidOfAuction(string id)
        {
            List<Bids> bd = bids.Where(x => x.UserId == id).ToList();
            var maxBids = from e in bd
                          group e by e.UserId into Auct
                          let top = Auct.Max(x => x.Value)
                          select new Bids
                          {
                              UserId = Auct.Key,
                              AuctionId = Auct.First(y => y.Value == top).AuctionId,
                              Value = top,
                              Id = Auct.First(y => y.Value == top).Id,
                          };
            return maxBids.Select(t => t.AuctionId).ToList();
        }

        public System.Data.Entity.DbSet<AuctionHouseMVC.Models.BidsViewModel> BidsViewModels { get; set; }
    }
}
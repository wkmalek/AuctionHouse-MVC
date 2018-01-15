using AuctionHouseMVC.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AuctionHouseMVC.Models
{
    public class AuctionContext : DbContext
    {
        public DbSet<Auctions> auctions { get; set; }

        public List<Auctions> ReturnSelectedAuction(string id, paramTypeForCategory type)
        {
            switch (type)
            {
                case paramTypeForCategory.byId:
                    return auctions.Where(x => x.Id == id).ToList();
                case paramTypeForCategory.byUserId:
                    return auctions.Where(x => x.CreatorId == id).ToList();
                case paramTypeForCategory.bySelectedCategory:
                    return auctions.Where(x => x.CategoryId == id).ToList();
                //case paramType.bySelectedCategoriesWithChildrens:

                //    break;
                default:
                    return auctions.Where(x => x.Id == id).ToList();
            }
        }


    }
}
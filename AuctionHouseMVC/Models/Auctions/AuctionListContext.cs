using AuctionHouseMVC;
using AuctionHouseMVC.Enums;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AuctionHouseMVC.Models
{
    public class AuctionListContext : DbContext
    {
        public AuctionContext auctions { get; set; }
        public CategoriesContext categories { get; set; }
        //public DbSet<Images> images { get; set; }
        //public DbSet<Bids> bids { get; set; }

        public List<AuctionListViewModels> AuctionListView { get; set; }
        
             

        public AuctionListContext(SortProperties prop, paramTypeForAuctionList param)
        {
            categories = new CategoriesContext();
            auctions = new AuctionContext();
            AuctionListView = new List<AuctionListViewModels>();
            AuctionListView = ReturnView(prop, param);
        }

        public List<AuctionListViewModels> ReturnView(SortProperties sortProperties, paramTypeForAuctionList param)
        {
            List<Auctions> selAuctions = ReturnAuctionList(param, sortProperties.id);

            foreach (Auctions item in selAuctions)
            {
                AuctionListView.Add(new AuctionListViewModels(item));
            }

            return AuctionListView;
        }



        private List<Auctions> ReturnAuctionList(paramTypeForAuctionList param, string Id)
        {

            List<string> auctionsByID = categories.GetCategoriesWithChildrens(Id);
           

            switch (param)
            {
                case paramTypeForAuctionList.byCategories:
                    return auctions.auctions.Where(x => auctionsByID.Contains(x.CategoryId)).ToList();
                    //return auctions.Where(x => auctionsByID.Contains(x.auctions)).ToList();

            }

            return null;
        }
    }



    

    public class SortProperties
    {
        public string id { get; set; }
    }
}



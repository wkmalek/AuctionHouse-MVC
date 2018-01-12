﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AuctionHouseMVC.Models
{
    public class AuctionPageContext :DbContext
    {
        public DbSet<Auctions> auctions { get; set; }
        public DbSet<Categories> categories { get; set; }
        public DbSet<Images> images { get; set; }
        public DbSet<Bids> bids { get; set; }

        public System.Data.Entity.DbSet<AuctionPageViewModel> AuctionPageViewModels { get; set; }
    }
   
}
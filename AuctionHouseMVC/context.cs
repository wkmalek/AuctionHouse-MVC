using AuctionHouseMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AuctionHouseMVC
{
    public class context: DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public context()
            //
            : base(@"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\aspnet-AuctionHouseMVC-20180112114212.mdf;Initial Catalog=aspnet-AuctionHouseMVC-20180112114212;Integrated Security=True")
        {

        }

       
    }
}
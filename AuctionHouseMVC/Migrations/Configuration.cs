namespace AuctionHouseMVC.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AuctionHouseMVC.context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AuctionHouseMVC.context context)
        {
            //Creating Dummy categories and sub categories  
            context.Categories.AddOrUpdate(c => c.Name,
              new Category { ID = "1", Name = "Main Cat1", Pid = null, Description = "Main Cat1" },
              new Category { ID = "2", Name = "Sub Main Cat1", Pid = "1", Description = "Sub Main Cat1" },
              new Category { ID = "3", Name = "Sub Sub", Pid = "2", Description = "Sub Sub" },
              new Category { ID = "4", Name = "Main Cat2", Pid = null, Description = "Main Cat2" },
              new Category { ID = "5", Name = "Main Cat3", Pid = null, Description = "Main Cat3" },
              new Category { ID = "6", Name = "Sub Main Cat3", Pid = null, Description = "Sub Main Cat3" }
              );
        }
    }
}

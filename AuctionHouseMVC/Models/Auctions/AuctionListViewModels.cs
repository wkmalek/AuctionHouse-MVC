using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuctionHouseMVC.Models
{
    public class AuctionListViewModels : IModel
    {
        private Auctions auction;
        [Key]
        public string Title { get; set; }
        public string StartPrice { get; set; }
        public string DateCreated { get; set; }
        public string DataExpires { get; set; }
        public string Description { get; set; }

        public AuctionListViewModels(Auctions item)
        {
            this.auction = item;
            UpdateProperties();
        }

        private void UpdateProperties()
        {
            Title = auction.Title;
            StartPrice = auction.StartPrice.ToString();
            if(auction.DateCreated != null) { 
            var dttemp = auction.DateCreated.Value.AddDays(auction.ExpiresIn);
            DataExpires = dttemp.ToString();
            }
            else
            {
                DataExpires = "";
            }
            DateCreated = auction.DateCreated.ToString();
            Description = auction.ShortDescription;
        }
    }
}
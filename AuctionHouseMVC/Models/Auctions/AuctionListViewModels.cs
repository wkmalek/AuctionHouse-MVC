using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuctionHouseMVC.Models
{
    public class AuctionListViewModels
    {
        private Auctions auction;
        [Key]
        public string Title { get; set; }
        public string EndingPrice { get; set; }
        public string DateCreated { get; set; }
        public string DateExpires { get; set; }
        public string Description { get; set; }
        public string Id { get; set; }

        public AuctionListViewModels(Auctions item)
        {
            this.auction = item;
            UpdateProperties();
        }

        private void UpdateProperties()
        {
            Title = auction.Title;
            EndingPrice = auction.EndingPrice.ToString();
            if(auction.DateCreated != null) { 
            var dttemp = auction.DateCreated.Value.AddDays(auction.ExpiresIn);
            DateExpires = dttemp.ToString();
            }
            else
            {
                DateExpires = "";
            }
            DateCreated = auction.DateCreated.ToString();
            Description = auction.ShortDescription;
            Id = auction.Id;
        }
    }
}
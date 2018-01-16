using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuctionHouseMVC.Models
{
    public class AuctionPageViewModel
    {
        private Auctions auction;

        public AuctionPageViewModel(Auctions auction)
        {
            this.auction = auction;
            UpdateProperties();     
                
        }

        private void UpdateProperties()
        {
            AuctionTitle = auction.Title;
            ActualPrice = auction.EndingPrice.ToString();
            StartingPrice = auction.StartPrice.ToString();
            CreatorName = HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(auction.CreatorId).UserName;
            CreatorId = auction.CreatorId;
            ShortDescription = auction.ShortDescription;
            LongDescription = auction.LongDescription;
            DateCreated = auction.DateCreated.ToString();
            if (auction.DateCreated != null)
            {
                var dttemp = auction.DateCreated.Value.AddDays(auction.ExpiresIn);
                DateEnd = dttemp.ToString();
            }
            else
            {
                DateEnd = "";
            }
            DateCreated = auction.DateCreated.ToString();
            Id = auction.Id;
            Currency = auction.Currency;
        }

        [Key]
        public string AuctionTitle { get; set; }
        public string ActualPrice { get; set; }
        public string StartingPrice { get; set; }
        public string Currency { get; set; }
        public string CreatorName { get; set; }
        public string CreatorId { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string DateCreated { get; set; }
        public string DateEnd { get; set; }
        public List<BidsViewModel> bidsViewModel { get; set; }
        public string Id { get; set; }
    }
}
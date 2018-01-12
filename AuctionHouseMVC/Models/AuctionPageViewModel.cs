using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuctionHouseMVC.Models
{
    public class AuctionPageViewModel
    {
        [Key]
        public string AuctionTitle { get; set; }
        public decimal ActualPrice { get; set; }
        public decimal StartingPrice { get; set; }
        public string Currency { get; set; }
        public string CreatorName { get; set; }
        public string CreatorId { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateEnd { get; set; }
        public List<BidsViewModel> bidsViewModel { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuctionHouseMVC.Models
{
    public class BidsViewModel
    {
        
        public string UserName { get; set;}
        [Key]
        public string UserUrl { get; set; }

        public decimal Value { get; set; }
        public string bidData { get; set; } 
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuctionHouseMVC.Models
{
    public class MainViewModel
    {
        public List<object> model { get; set; }
        public IEnumerable<Category> cat { get; set; }

        public MainViewModel(List<object> model, IEnumerable<Category> cat)
        {
            this.model = model;
            this.cat = cat;
        }
    }
}
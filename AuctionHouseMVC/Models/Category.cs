using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AuctionHouseMVC.Models
{
    public class Category
    {
        //Cat Id
        public string ID { get; set; }

        //Cat Name
        public string Name { get; set; }

        //Cat description
        public string Description { get; set; }

        //Parent ID
        public string Pid { get; set; }
        [ForeignKey("Pid")]
        public virtual Category Parent { get; set; }
        public virtual ICollection<Category> Childs { get; set; }
    }
}
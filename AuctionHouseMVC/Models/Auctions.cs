namespace AuctionHouseMVC
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Data.Entity.Spatial;

    public partial class Auctions : DbContext
    {
        AuctionPageViewModel vm = new AuctionPageViewModel();

        public string Id { get; set; }

        [StringLength(128)]
        public string CategoryId { get; set; }

        [StringLength(128)]
        public string Title { get; set; }

        public decimal? StartPrice { get; set; }

        public decimal? EndingPrice { get; set; }

        public DateTime? DateCreated { get; set; }

        public int ExpiresIn { get; set; }

        [Column(TypeName = "text")]
        public string ShortDescription { get; set; }

        public bool IsEnded { get; set; }

        [StringLength(128)]
        public string CreatorId { get; set; }

        [StringLength(128)]
        public string WinnerId { get; set; }

        [Column(TypeName = "text")]
        public string LongDescription { get; set; }
    }
}

namespace AuctionHouseMVC
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Images
    {
        public string Id { get; set; }

        [MaxLength(8000)]
        public byte[] Image { get; set; }

        [StringLength(128)]
        public string AuctionId { get; set; }

        public int? Index { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuctionHouseMVC
{
    public class CreateAuctionViewModel
    {

        public string Id { get; set; }

        [StringLength(128)]
        public string CategoryId { get; set; }

        [StringLength(128)]
        public string AuctionTitle { get; set; }

        public decimal? PriceStart { get; set; }

        public decimal? EndingPrice { get; set; }

        public DateTime? DateCreated { get; set; }

        public string Currency { get; set; }

        public IEnumerable<SelectListItem> ExpiresIn { get; set; }

        [Column(TypeName = "text")]
        public string DescriptionShort { get; set; }

        [StringLength(128)]
        public string CreatorId { get; set; }

        [Column(TypeName = "text")]
        public string DescriptionLong { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuctionHouseMVC.Enums
{
    public enum paramTypeForCategory
    {
        byId,
        byUserId,
        bySelectedCategory,
        bySelectedCategoriesWithChildrens,
    }

    public enum paramTypeForAuctionList
    {
        byCategories,

    }
}
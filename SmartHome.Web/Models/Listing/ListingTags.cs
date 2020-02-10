using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHome.Web.Models.Listing
{
    public class ListingTags
    {
        public int ListingId { get; set; }
        public Listing Listing { get; set; }

        public int TagId { get; set; }
        public Tag Tag { get; set; }
    }
}

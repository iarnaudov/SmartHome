using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHome.Web.Models.Listing
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<ListingTags> Listings { get; set; }
    }
}

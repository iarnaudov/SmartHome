using SmartHome.Web.Models;
using SmartHome.Web.Models.Listing;
using SmartHome.Web.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHome.Web.Models.Listing
{
    public class Listing
    {
        public int Id { get; set; }
        public AppUser Author { get; set; }
        public ListingType Type { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ListingNumber { get; set; }
        public List<Image> Images { get; set; }
        public List<Perk> Perks { get; set; }
        public int LocationId  { get; set; }
        public Location Location { get; set; }
        public IList<ListingTags> Tags { get; set; }
    }
}

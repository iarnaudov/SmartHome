using System.Collections.Generic;

namespace SmartHome.Web.Models.Listing
{
    public class Location
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }

        public ICollection<Listing> Listings { get; set; }
    }
}
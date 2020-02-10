using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHome.Models
{
    public class Listing
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ListingNumber { get; set; }
        public List<Image> Images { get; set; }
        public Location Location { get; set; }
        public List<Perk> Perks { get; set; }
    }
}

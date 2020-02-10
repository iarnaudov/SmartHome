using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using SmartHome.Web.Models.Listing;

namespace SmartHome.Web.Models.User
{
    public class AppUser : IdentityUser<int>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public IList<Listing.Listing> Listings { get; set; }
    }
}

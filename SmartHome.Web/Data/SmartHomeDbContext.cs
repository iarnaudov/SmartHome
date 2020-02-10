using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SmartHome.Web.Models.Listing;
using SmartHome.Web.Models.User;

namespace SmartHome.Web.Data
{
    public class SmartHomeDbContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public SmartHomeDbContext(DbContextOptions<SmartHomeDbContext> options)
            : base(options)
        {
        }

        public DbSet<Listing> Listings { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Perk> Perks { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ListingTags>().HasKey(lt => new { lt.TagId, lt.ListingId });
        }
    }
}

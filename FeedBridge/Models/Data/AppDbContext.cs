using FeedBridge.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FeedBridge.Models.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Support> Supports { get; set; }
        public DbSet<Donnation> Donnations { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Report> Reports{ get; set; }
        public DbSet<Review> Reviews{ get; set; }
        public DbSet<StaticPage> StaticPages{ get; set; }
        public DbSet<Setting> Settings{ get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Order>()
                .Property(x => x.Status)
                .HasConversion<string>();

            builder.Entity<Report>().HasOne(x => x.CreatedBy).WithMany(x => x.ReportsCreated).HasForeignKey(x => x.CreatedById);
            builder.Entity<Report>().HasOne(x => x.TargetUser).WithMany(x => x.ReportsReceived).HasForeignKey(x => x.TargetUserId);
        }

    }
     
}

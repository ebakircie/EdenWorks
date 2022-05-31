using EdenWorks.Domain.Entites;
using EdenWorks.Infrastructure.EntityTypeConfig;
using EdenWorks.Infrastructure.SeedData;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;




namespace EdenWorks.Infrastructure
{
    public class AppDbContext : IdentityDbContext<AppUser, IdentityRole<int>, int>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AppUserConfig());
            builder.ApplyConfiguration(new CategoryConfig());
            builder.ApplyConfiguration(new ProductConfig());

            builder.ApplyConfiguration(new AdminSeeding());
            builder.ApplyConfiguration(new CategorySeeding());
            builder.ApplyConfiguration(new ProductSeeding());


            base.OnModelCreating(builder);
        }

       
    }

}

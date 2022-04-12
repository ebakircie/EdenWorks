using EdenWorks.Domain.Entites;
using Infrastructure.EntityTypeConfig;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure
{
    public class AppDbContext:IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options) { }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AppUserConfig());
            builder.ApplyConfiguration(new CategoryConfig());
            builder.ApplyConfiguration(new ProductConfig());


            base.OnModelCreating(builder);
        }
    }

}

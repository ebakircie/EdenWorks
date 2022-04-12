using EdenWorks.Domain.Entites;
using EdenWorks.Infrastructure.EntityTypeConfig;
using EdenWorks.Infrastructure.Utilities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;




namespace EdenWorks.Infrastructure
{
    public class AppDbContext : IdentityDbContext<AppUser>
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


            base.OnModelCreating(builder);
        }

        public override int SaveChanges()
        {
            var entityEntries = ChangeTracker.Entries().Where(x => x.State == EntityState.Added || x.State==EntityState.Modified||x.State==EntityState.Deleted);

            string computerName = Environment.MachineName;
            DateTime dateTime= DateTime.Now;
            string ip = CatchIP.IpAddress;

            foreach (var item in entityEntries)
            {
                IBaseEntity entity = item.Entity as IBaseEntity;
                switch (item.State)
                {
                    case EntityState.Deleted:
                        entity.DeletedDate = dateTime;
                        entity.DeletedIpAddress = ip;
                        entity.DeletedMachineName = computerName;
                        break;
                    case EntityState.Modified:
                        entity.UpdatedDate = dateTime;
                        entity.UpdatedIpAddress = ip;
                        entity.UpdatedMachineName = computerName;
                        break;
                    case EntityState.Added:
                        entity.CreatedDate = dateTime;
                        entity.CreatedIpAddress = ip;
                        entity.CreatedMachineName = computerName;
                        break;
                }
            }
            return base.SaveChanges();
        }
    }

}

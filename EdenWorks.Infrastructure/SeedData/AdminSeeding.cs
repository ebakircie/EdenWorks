using EdenWorks.Domain.Entites;
using EdenWorks.Domain.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdenWorks.Infrastructure.SeedData
{
    public class AdminSeeding : IEntityTypeConfiguration<AppUser>
    {
       
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            var hasher = new PasswordHasher<AppUser>();
            builder.HasData(
                new AppUser { Id = 9, UserName = "admin",NormalizedUserName="ADMIN", Email = "admin@gmail.com",PasswordHash=hasher.HashPassword(null,"qwxx123"),SecurityStamp=Guid.NewGuid().ToString(),
                    Status=Status.Active,CreatedDate=DateTime.Now }
                );

            
            
        }
    }
}

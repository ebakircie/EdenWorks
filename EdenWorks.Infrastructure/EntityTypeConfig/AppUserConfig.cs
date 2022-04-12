using EdenWorks.Domain.Entites;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdenWorks.Infrastructure.EntityTypeConfig
{
    public class AppUserConfig : BaseEntityConfig<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.NormalizedUserName).IsRequired(false);
            builder.Property(x => x.UserName).IsRequired(true);

            base.Configure(builder);
        }
    }
}

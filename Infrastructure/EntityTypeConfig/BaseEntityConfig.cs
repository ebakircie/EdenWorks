using EdenWorks.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.EntityTypeConfig
{
    public abstract class BaseEntityConfig<T> : IEntityTypeConfiguration<T> where T : class, IBaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(x => x.CreatedDate).IsRequired(true);
            builder.Property(x => x.CreatedIpAddress).IsRequired(true);
            builder.Property(x => x.CreatedMachineName).IsRequired(true);

            builder.Property(x => x.UpdatedDate).IsRequired(false);
            builder.Property(x => x.UpdatedIpAddress).IsRequired(false);
            builder.Property(x => x.UpdatedMachineName).IsRequired(false);

            builder.Property(x => x.DeletedDate).IsRequired(false);
            builder.Property(x => x.DeletedIpAddress).IsRequired(false);
            builder.Property(x => x.DeletedMachineName).IsRequired(false);
            builder.Property(x => x.Status).IsRequired(true);
        }
    }
}

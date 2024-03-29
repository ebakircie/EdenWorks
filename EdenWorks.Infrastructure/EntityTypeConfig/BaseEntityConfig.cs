﻿using EdenWorks.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdenWorks.Infrastructure.EntityTypeConfig
{
    public abstract class BaseEntityConfig<T> : IEntityTypeConfiguration<T> where T : class, IBaseEntity
    {
        // Configuration of base properties.
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(x => x.CreatedDate).IsRequired(true);
            builder.Property(x => x.CreatedIpAddress).IsRequired(false).HasMaxLength(15);
            builder.Property(x => x.CreatedMachineName).IsRequired(false).HasMaxLength(100);

            builder.Property(x => x.UpdatedDate).IsRequired(false);
            builder.Property(x => x.UpdatedIpAddress).IsRequired(false).HasMaxLength(15);
            builder.Property(x => x.UpdatedMachineName).IsRequired(false).HasMaxLength(100);

            builder.Property(x => x.DeletedDate).IsRequired(false);
            builder.Property(x => x.DeletedIpAddress).IsRequired(false).HasMaxLength(15);
            builder.Property(x => x.DeletedMachineName).IsRequired(false).HasMaxLength(100);
            
        }
    }
}

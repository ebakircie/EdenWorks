using EdenWorks.Domain.Entites;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdenWorks.Infrastructure.EntityTypeConfig
{
    public class CategoryConfig : BaseEntityConfig<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            // Category configuration
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CategoryName).IsRequired(true).HasMaxLength(50);

            

            base.Configure(builder);
        }
    }
}

using EdenWorks.Domain.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdenWorks.Infrastructure.EntityTypeConfig
{
    public class ProductConfig : BaseEntityConfig<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).IsRequired(false).HasMaxLength(50);
            builder.Property(x => x.Description).IsRequired(false).HasMaxLength(500);
            builder.Property(x => x.ImagePath).IsRequired(false);
            builder.Property(x => x.Price)
                .HasPrecision(18, 5)
                .HasConversion<decimal>()
                .IsRequired(true);


            //Relations
            builder.HasOne(x => x.Category)
                   .WithMany(x => x.Products)
                   .HasForeignKey(x => x.CategoryId)
                   .OnDelete(DeleteBehavior.Restrict);


            base.Configure(builder);

        }
    }
}

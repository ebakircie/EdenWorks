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
    public class ProductConfig:BaseEntityConfig<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x=> x.Name).IsRequired(true).HasMaxLength(50);
            builder.Property(x=> x.Description).IsRequired(false).HasMaxLength(500);
            builder.Property(x => x.Price).IsRequired(true);

            //Relations
            builder.HasOne(x => x.Category)
                   .WithMany(x => x.Products)
                   .HasForeignKey(x => x.CategoryId)
                   .OnDelete(DeleteBehavior.Restrict);
                    
            
            base.Configure(builder);

        }
    }
}

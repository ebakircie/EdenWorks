using EdenWorks.Domain.Entites;
using EdenWorks.Domain.Enums;
using EdenWorks.Infrastructure.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdenWorks.Infrastructure.SeedData
{
    public class CategorySeeding : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id = 1, CategoryName = "SALATALAR / SALADS", CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active },
                new Category { Id = 2, CategoryName = "APERATİFLER / SNACKS", CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active },
                new Category { Id = 3, CategoryName = "TOSTLAR / TOASTS", CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active },
                new Category { Id = 4, CategoryName = "BURGERLER / BURGERS", CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active },
                new Category { Id = 5, CategoryName = "PİDELER / PIDES", CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active },
                new Category { Id = 6, CategoryName = "PİZZALAR / PIZZAS", CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active },
                new Category { Id = 7, CategoryName = "QUESADILLAS & WRAPS", CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active },
                new Category { Id = 8, CategoryName = "MEZELER / MEZZES", CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active },
                new Category { Id = 9, CategoryName = "IZGARALAR / GRILLS", CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active },
                new Category { Id = 10, CategoryName = "MAKARNALAR / PASTAS", CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active },
                new Category { Id = 11, CategoryName = "KAHVELER / COFFEES", CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active },
                new Category { Id = 12, CategoryName = "SOFT DRINKS", CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active },
                new Category { Id = 13, CategoryName = "BİRALAR / BEERS", CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active },
                new Category { Id = 14, CategoryName = "RAKILAR / RAKI", CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active },
                new Category { Id = 15, CategoryName = "ŞARAPLAR / VINES", CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active },
                new Category { Id = 16, CategoryName = "DİĞER İÇKİLER / HARD LIQUORS", CreatedDate = DateTime.Now, CreatedIpAddress = CatchIP.IpAddress, CreatedMachineName = Environment.MachineName, Status = Status.Active }
                );
        }
    }
}

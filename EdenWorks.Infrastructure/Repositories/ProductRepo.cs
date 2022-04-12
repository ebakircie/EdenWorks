using EdenWorks.Domain.Entites;
using EdenWorks.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdenWorks.Infrastructure.Repositories
{
    public class ProductRepo:BaseRepo<Product>, IProductRepo
    {
        public ProductRepo(AppDbContext appDbContext):base(appDbContext)
        {

        }
    }
}

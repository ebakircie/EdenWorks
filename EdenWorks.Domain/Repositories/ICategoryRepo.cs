using EdenWorks.Domain.Entites;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EdenWorks.Domain.Repositories
{
    public interface ICategoryRepo : IBaseRepo<Category>
    {

    }
}

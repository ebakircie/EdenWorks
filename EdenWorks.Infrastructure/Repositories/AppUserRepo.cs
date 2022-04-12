using EdenWorks.Domain.Entites;
using EdenWorks.Domain.Repositories;


namespace EdenWorks.Infrastructure.Repositories
{
    public class AppUserRepo:BaseRepo<AppUser>,IAppUserRepo
    {
        public AppUserRepo(AppDbContext appDbContext):base(appDbContext)
        {

        }
    }
}

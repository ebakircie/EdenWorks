using EdenWorks.Domain.Entites;
using EdenWorks.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace EdenWorks.Infrastructure.Repositories
{
    public class BaseRepo<T> : IBaseRepo<T> where T : class, IBaseEntity
    {
        private readonly AppDbContext _appDbContext;
        protected DbSet<T> table;

        public BaseRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            table = _appDbContext.Set<T>();
        }

        public void Create(T entity)
        {
            table.Add(entity);
            _appDbContext.SaveChanges();
        }
        public void Update(T entity)
        {
            _appDbContext.Entry<T>(entity).State = EntityState.Modified;
            _appDbContext.SaveChanges();
        }
        public async Task Delete(T entity)
        {
            await _appDbContext.SaveChangesAsync();
        }
        public async Task SetActive(T entity)
        {
            await _appDbContext.SaveChangesAsync();
        }
        public async Task<bool> Any(Expression<Func<T, bool>> exception)
        {
            return await table.AnyAsync(exception);
        }

        public async Task<T> GetDefault(Expression<Func<T, bool>> expression)
        {
            return await table.FirstOrDefaultAsync(expression);
        }

        public async Task<List<T>> GetDefaults(Expression<Func<T, bool>> expression)
        {
            return await table.Where(expression).ToListAsync();
        }

        public async Task<TResult> GetFilteredFirstOrDefault<TResult>(Expression<Func<T, TResult>> select,
                                                          Expression<Func<T, bool>> where, Func<IQueryable<T>,
                                                          IOrderedQueryable<T>> orderBy = null,
                                                          Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null)
        {
            IQueryable<T> query = table;

            if (where != null)
            {
                query = query.Where(where);
            }
            if (include != null)
            {
                query = include(query);
            }
            if (orderBy != null)
            {
                return await orderBy(query).Select(select).FirstOrDefaultAsync();
            }
            else
            {
                return await query.Select(select).FirstOrDefaultAsync();
            }
        }

        public async Task<List<TResult>> GetFilteredList<TResult>(Expression<Func<T, TResult>> select,
                                                      Expression<Func<T, bool>> where, Func<IQueryable<T>,
                                                      IOrderedQueryable<T>> orderBy = null, Func<IQueryable<T>,
                                                      IIncludableQueryable<T, object>> include = null)
        {
            IQueryable<T> query = table;

            if (where != null)
            {
                query = query.Where(where);
            }
            if (include != null)
            {
                query = include(query);
            }
            if (orderBy != null)
            {
                return await orderBy(query).Select(select).ToListAsync();
            }
            else
            {
                return await query.Select(select).ToListAsync();
            }
        }

       
    }
}

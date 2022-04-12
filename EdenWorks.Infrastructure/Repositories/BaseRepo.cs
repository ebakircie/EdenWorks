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
        public void Delete(T entity)
        {
            _appDbContext.SaveChanges();
        }
        public bool Any(Expression<Func<T, bool>> exception)
        {
            return table.Any(exception);
        }

        public T GetDefault(Expression<Func<T, bool>> expression)
        {
            return table.FirstOrDefault(expression);
        }

        public List<T> GetDefaults(Expression<Func<T, bool>> expression)
        {
            return table.Where(expression).ToList();
        }

        public TResult GetFilteredFirstOrDefault<TResult>(Expression<Func<T, TResult>> select,
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
                return orderBy(query).Select(select).FirstOrDefault();
            }
            else
            {
                return query.Select(select).FirstOrDefault();
            }
        }

        public List<TResult> GetFilteredList<TResult>(Expression<Func<T, TResult>> select,
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
                return orderBy(query).Select(select).ToList();
            }
            else
            {
                return query.Select(select).ToList();
            }
        }


    }
}

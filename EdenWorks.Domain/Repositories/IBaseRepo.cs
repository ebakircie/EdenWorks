﻿using EdenWorks.Domain.Entites;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EdenWorks.Domain.Repositories
{
    public interface IBaseRepo<T> where T : IBaseEntity
    {
        void Create (T entity);
        void Update (T entity);
        void Delete (T entity);

        T GetDefault(Expression<Func<T, bool>> expression);
        List<T> GetDefaults (Expression<Func<T, bool>> expression);

        bool Any(Expression<Func<T, bool>> exception);

        TResult GetFilteredFirstOrDefault<TResult>(Expression<Func<T, TResult>> select,
                                                         Expression<Func<T, bool>> where,
                                                         Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                                         Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);

        List<TResult> GetFilteredList<TResult>(Expression<Func<T, TResult>> select,
                                                   Expression<Func<T, bool>> where,
                                                   Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                                   Func<IQueryable<T>, IIncludableQueryable<T, object>> include = null);
    }

}
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace MyAPI.Data
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Remove(T entity);

    }
}
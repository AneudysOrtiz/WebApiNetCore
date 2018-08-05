using System.Collections.Generic;
using System.Linq.Expressions;

namespace MyAPI.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private MyApiContext _db;
        public Repository(MyApiContext db)
        {
            _db = db;
        }
        public void Add(T entity)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<T> Find(Expression<System.Func<T, bool>> predicate)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public T GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
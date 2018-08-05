using System.Collections.Generic;
using System.Linq;
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
            _db.Set<T>().Add(entity);
        }

        public IEnumerable<T> Find(Expression<System.Func<T, bool>> predicate)
        {
            return _db.Set<T>().Where(predicate);
        }

        public IEnumerable<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public void Remove(T entity)
        {
            _db.Set<T>().Remove(entity);
        }
    }
}
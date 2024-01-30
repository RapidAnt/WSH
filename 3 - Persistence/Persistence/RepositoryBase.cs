using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Data_Layer;

namespace Persistence
{
    public class RepositoryBase<T> where T : class
    {
        protected readonly AppDbContext _context;

        public RepositoryBase(AppDbContext context)
        {
            _context = context;
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public void Add(T item)
        {
            _context.Set<T>().Add(item);
        }

        public void Remove(T item)
        {
            _context.Set<T>().Remove(item);
        }

        public List<T> Find(Expression<Func<T, bool>> predicate)
        {
            return _context.Set<T>().Where(predicate).ToList() ?? new List<T>();
        }
    }
}

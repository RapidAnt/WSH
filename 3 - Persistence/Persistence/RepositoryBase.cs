using System.Collections.Generic;
using System.Linq;
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
    }
}

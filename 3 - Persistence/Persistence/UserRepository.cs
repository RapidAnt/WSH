using System.Collections.Generic;
using System.Linq;
using Data_Layer;

namespace Persistence
{
    public class UserRepository
    {
        protected readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<User> GetAll()
        {
            return _context.Users.ToList();
        }
    }
}

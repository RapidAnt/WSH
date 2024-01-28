using System.Linq;
using Data_Layer;

namespace Persistence
{
    public class UserRepository : RepositoryBase<User>
    {
        public UserRepository(AppDbContext context):base(context)
        {
        }

        public User GetUserByEmailAndPassword(string email, string password)
        {
            return _context.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
        }
    }
}

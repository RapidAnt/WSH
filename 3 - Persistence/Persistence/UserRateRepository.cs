using Data_Layer;
using Data_Layer.Models;

namespace Persistence
{
    public class UserRateRepository : RepositoryBase<UserRate>
    {
        public UserRateRepository(AppDbContext context) : base(context)
        {
        }
    }
}

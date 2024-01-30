using Data_Layer;
using System.Threading.Tasks;

namespace Application
{
    public interface ILoginService
    {
        Task<bool> CanLogIn(string email, string password);
        Task<User> GetUserByEmail(string email);
        Task<User> GetUserByEmailAndPassword(string email, string password);
    }
}

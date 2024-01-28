using Data_Layer;
using System.Collections.Generic;

namespace Application
{
    public interface ILoginService
    {
        bool CanLogIn(string email, string password);
        User GetUserByEmail(string email);
        User GetUserByEmailAndPassword(string email, string password);
        List<User> GetAllUser();
    }
}

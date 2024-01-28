using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public interface IRegistrationService
    {
        void RegisterUser(string userName, string email, string password);
        string GenerateHash(string password);
    }
}

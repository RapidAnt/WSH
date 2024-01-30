using System.Threading.Tasks;

namespace Application
{
    public interface IRegistrationService
    {
        Task RegisterUser(string userName, string email, string password);
        Task<string> GenerateHash(string password);
    }
}

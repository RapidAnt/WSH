namespace Application
{
    public interface IRegistrationService
    {
        void RegisterUser(string userName, string email, string password);
        string GenerateHash(string password);
    }
}

using System.Collections.Generic;
using System.Linq;
using Data_Layer;
using Persistence;

namespace Application
{
    public class LoginService : ILoginService
    {
        private readonly UnitOfWork _unitOfWork;
        private RegistrationService _registrationService = new RegistrationService();

        public LoginService()
        {
            AppDbContext db = new AppDbContext();
            _unitOfWork = new UnitOfWork(db);
        }

        public LoginService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public bool CanLogIn(string email, string password)
        {
            string hash = _registrationService.GenerateHash(password);

            bool userFound = GetAllUser().Any(u => u.Email == email && u.Password == hash);

            return userFound;
        }

        public User GetUserByEmail(string email)
        {
            User user = GetAllUser().FirstOrDefault(u => u.Email == email);

            return user;
        }

        public User GetUserByEmailAndPassword(string email, string password)
        {
            string hash = _registrationService.GenerateHash(password);

            User user = GetAllUser().FirstOrDefault(u => u.Email == email && u.Password == hash);
            User user2 = _unitOfWork.Users.GetUserByEmailAndPassword(email, hash);

            return user;
        }

        public List<User> GetAllUser()
        {
            return _unitOfWork.Users.GetAll();
        }
    }
}

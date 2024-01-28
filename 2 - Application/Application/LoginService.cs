using System.Collections.Generic;
using System.Linq;
using Data_Layer;
using Persistence;

namespace Application
{
    public class LoginService
    {
        private readonly UnitOfWork _unitOfWork;

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
            bool userFound = GetAllUser().Any(u => u.Email == email && u.Password == password);

            return userFound;
        }

        public User GetUser(string email, string password)
        {
            User user = GetAllUser().FirstOrDefault(u => u.Email == email && u.Password == password);

            return user;
        }

        public List<User> GetAllUser()
        {
            return _unitOfWork.Users.GetAll();
        }
    }
}

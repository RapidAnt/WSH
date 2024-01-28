using System;
using System.Security.Cryptography;
using System.Text;
using Data_Layer;
using Persistence;

namespace Application
{
    public class RegistrationService : IRegistrationService
    {
        private readonly UnitOfWork _unitOfWork;

        public RegistrationService()
        {
            AppDbContext db = new AppDbContext();
            _unitOfWork = new UnitOfWork(db);
        }

        public RegistrationService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void RegisterUser(string userName, string email, string password)
        {
            _unitOfWork.Users.Add(new User(userName, email, password));
            _unitOfWork.Save();
        }

        public string GenerateHash(string password)
        {
            string hash = String.Empty;
            string salt = "The salt could be come from the DB as well as the part of an user data.";

            using (MD5 md5 = MD5.Create())
            {
                var comphash = md5.ComputeHash((Encoding.UTF8.GetBytes(password + salt)));
                hash = BitConverter.ToString(comphash).Replace("-", "");
            }

            return hash;
        }
    }
}

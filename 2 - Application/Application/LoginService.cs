using System.Linq;
using System.Threading.Tasks;
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

        public async Task<bool> CanLogIn(string email, string password)
        {
            string hash = await _registrationService.GenerateHash(password);

            bool userFound = _unitOfWork.Users.Find(u => u.Email == email && u.Password == hash).Any();

            return userFound;
        }

        public async Task<User> GetUserByEmail(string email)
        {
            User user = _unitOfWork.Users.Find(u => u.Email == email).FirstOrDefault();

            return user;
        }

        public async Task<User> GetUserByEmailAndPassword(string email, string password)
        {
            string hash = await _registrationService.GenerateHash(password);

            User user = _unitOfWork.Users.Find(u => u.Email == email && u.Password == hash).FirstOrDefault();

            return user;
        }
    }
}

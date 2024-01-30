using System.Collections.Generic;
using System.Linq;
using Application.Interfaces;
using Data_Layer;
using Data_Layer.Models;
using Persistence;

namespace Application
{
    public class UserRatesService : IUserRatesService
    {
        private readonly UnitOfWork _unitOfWork;

        public UserRatesService()
        {
            AppDbContext db = new AppDbContext();
            _unitOfWork = new UnitOfWork(db);
        }

        public UserRatesService(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void SaveUserRate(UserRate userRate)
        {
            _unitOfWork.UserRates.Add(userRate);
            _unitOfWork.Save();
        }

        public void DeleteUserRate(int userId, int userRateId)
        {
            UserRate userrate = _unitOfWork.UserRates.Find(rate => rate.UserId == userId && rate.Id == userRateId).FirstOrDefault();
            if (userrate != null)
            {
                _unitOfWork.UserRates.Remove(userrate);
                _unitOfWork.Save();
            }
        }

        public void UpdateCommentInUserRate(int userId, int userRateId, string comment)
        {
            UserRate userrate = _unitOfWork.UserRates.Find(rate => rate.UserId == userId && rate.Id == userRateId).FirstOrDefault();

            if (userrate != null)
            {
                userrate.Comment = comment;
                _unitOfWork.Save();
            }
        }

        public List<UserRate> GetRelatedUserRates(int userId)
        {
            return _unitOfWork.UserRates.Find(userRate => userRate.UserId == userId);
        }
    }
}

using Data_Layer.Models;
using System.Collections.Generic;

namespace Application.Interfaces
{
    public interface IUserRatesService
    {
        void SaveUserRate(UserRate userRate);
        List<UserRate> GetRelatedUserRates(int userId);
        void DeleteUserRate(int userId, int userRateId);
        void UpdateCommentInUserRate(int userId, int userRateId, string comment);
    }
}

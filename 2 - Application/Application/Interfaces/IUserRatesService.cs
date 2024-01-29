using Data_Layer.Models;
using System.Collections.Generic;

namespace Application.Interfaces
{
    public interface IUserRatesService
    {
        void SaveUserRate(UserRate userRate);
        List<UserRate> GetRelatedUserRates(int userId);
    }
}

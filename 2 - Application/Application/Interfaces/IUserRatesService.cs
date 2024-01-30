using Data_Layer.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IUserRatesService
    {
        Task SaveUserRate(UserRate userRate);
        Task<List<UserRate>> GetRelatedUserRates(int userId);
        Task DeleteUserRate(int userId, int userRateId);
        Task UpdateCommentInUserRate(int userId, int userRateId, string comment);
    }
}

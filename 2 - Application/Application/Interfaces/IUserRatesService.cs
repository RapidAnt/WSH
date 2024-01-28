using Data_Layer.Models;

namespace Application.Interfaces
{
    public interface IUserRatesService
    {
        void SaveUserRate(UserRate userRate);
    }
}

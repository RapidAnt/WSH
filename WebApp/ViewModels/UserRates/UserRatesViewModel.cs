using System.Collections.Generic;
using Data_Layer.Models;

namespace WebApp.ViewModels.UserRates
{
    public class UserRatesViewModel
    {
        public List<UserRate> UserRates { get; set; } = new List<UserRate>();

        public UserRatesViewModel(List<UserRate> userRates)
        {
            UserRates.AddRange(userRates);
        }
    }
}
using System.Collections.Generic;
using Data_Layer.DTO_Models;

namespace WebApp.ViewModels.Rates
{
    public class RatesViewModel
    {
        public string Date { get; set; }
        public List<Rate> Rates { get; set; } = new List<Rate>();

        public RatesViewModel(MnbCurrentExchangeRates currentExchangeRates)
        {
            Date = currentExchangeRates.Day.Date;
            Rates.AddRange(currentExchangeRates.Day.Rates);
        }
    }
}
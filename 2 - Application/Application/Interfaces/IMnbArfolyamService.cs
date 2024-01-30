using Data_Layer.DTO_Models;
using System.Threading.Tasks;

namespace Application
{
    public interface IMnbArfolyamService
    {
        Task<MnbExchangeRatesQueryValues> GetInfo();
        Task<MnbCurrencies> GetCurrencies();
        Task<MnbCurrencyUnits> GetCurrencyUnits();
        Task<MnbCurrentExchangeRates> GetCurrentExchangeRates();
        Task<MnbStoredInterval> GetDateInterval();
        Task<MnbExchangeRates> GetExchangeRates(string startdate, string endDate, string currencies);
    }
}

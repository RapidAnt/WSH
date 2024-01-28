using Data_Layer.DTO_Models;

namespace Application
{
    public interface IMnbArfolyamService
    {
        MnbExchangeRatesQueryValues GetInfo();
        MnbCurrencies GetCurrencies();
        MnbCurrencyUnits GetCurrencyUnits();
        MnbCurrentExchangeRates GetCurrentExchangeRates();
        MnbStoredInterval GetDateInterval();
        MnbExchangeRates GetExchangeRates(string startdate, string endDate, string currencies);
    }
}

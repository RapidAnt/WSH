using Application.MNBArfolyamServiceSoapClient;
using Data_Layer.DTO_Models;

namespace Application
{
    public class MnbArfolyamService : IMnbArfolyamService
    {
     
        private readonly IConverter _xmlConcerterService;

        public MnbArfolyamService()
        {
            _xmlConcerterService = new XmlConcerterService();
        }

        public MnbExchangeRatesQueryValues GetInfo()
        {
            MnbExchangeRatesQueryValues result;

            using (var client = new MNBArfolyamServiceSoapClient.MNBArfolyamServiceSoapClient())
            {
                var request = new GetInfoRequestBody();
                GetInfoResponseBody response = client.GetInfo(request);
                result = _xmlConcerterService.ConvertFrom<MnbExchangeRatesQueryValues>(response.GetInfoResult);

                client.Close();
            }

            return result;
        }

        public MnbCurrencies GetCurrencies()
        {
            MnbCurrencies result;

            using (var client = new MNBArfolyamServiceSoapClient.MNBArfolyamServiceSoapClient())
            {
                var request = new GetCurrenciesRequestBody();
                GetCurrenciesResponseBody response = client.GetCurrencies(request);
                result = _xmlConcerterService.ConvertFrom<MnbCurrencies>(response.GetCurrenciesResult);

                client.Close();
            }

            return result;
        }

        public MnbCurrencyUnits GetCurrencyUnits()
        {
            MnbCurrencyUnits result;

            using (var client = new MNBArfolyamServiceSoapClient.MNBArfolyamServiceSoapClient())
            {
                var request = new GetCurrencyUnitsRequestBody();
                request.currencyNames = "EUR,USD";

                GetCurrencyUnitsResponseBody response = client.GetCurrencyUnits(request);

                result = _xmlConcerterService.ConvertFrom<MnbCurrencyUnits>(response.GetCurrencyUnitsResult);

                client.Close();
            }

            return result;
        }

        public MnbCurrentExchangeRates GetCurrentExchangeRates()
        {
            MnbCurrentExchangeRates result;

            using (var client = new MNBArfolyamServiceSoapClient.MNBArfolyamServiceSoapClient())
            {
                var request = new GetCurrentExchangeRatesRequestBody();

                GetCurrentExchangeRatesResponseBody response = client.GetCurrentExchangeRates(request);

                result = _xmlConcerterService.ConvertFrom<MnbCurrentExchangeRates>(response
                    .GetCurrentExchangeRatesResult);

                client.Close();
            }

            return result;
        }

        public MnbStoredInterval GetDateInterval()
        {
            MnbStoredInterval result;

            using (var client = new MNBArfolyamServiceSoapClient.MNBArfolyamServiceSoapClient())
            {
                GetDateIntervalResponseBody response = client.GetDateInterval(new GetDateIntervalRequestBody());
                result = _xmlConcerterService.ConvertFrom<MnbStoredInterval>(response.GetDateIntervalResult);
                client.Close();
            }

            return result;
        }

        public MnbExchangeRates GetExchangeRates(string startDate, string endDate, string currencies)
        {
            MnbExchangeRates result;

            using (var client = new MNBArfolyamServiceSoapClient.MNBArfolyamServiceSoapClient())
            {
                var request = new GetExchangeRatesRequestBody();
                request.startDate = startDate;
                request.endDate = endDate;
                request.currencyNames = currencies;

                GetExchangeRatesResponseBody response = client.GetExchangeRates(request);
                result = _xmlConcerterService.ConvertFrom<MnbExchangeRates>(response.GetExchangeRatesResult);

                client.Close();
            }

            return result;
        }
    }
}
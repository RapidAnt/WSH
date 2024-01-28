using System.Web.Mvc;
using Application;
using Data_Layer.DTO_Models;
using WebApp.ViewModels.Rates;

namespace WebApp.Controllers
{
    [Authorize]
    public class RatesController : Controller
    {
        private readonly IMnbArfolyamService _mnbArfolyamService = new MnbArfolyamService();
        public ActionResult CurrentRates()
        {
            var currentExchangeRates = _mnbArfolyamService.GetCurrentExchangeRates();

            RatesViewModel viewModel = new RatesViewModel();
            viewModel.Date = currentExchangeRates.Day.Date;

            return View("CurrentRates", viewModel);
        }
    }
}
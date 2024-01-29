using System;
using System.Web.Mvc;
using Application;
using Application.Interfaces;
using Data_Layer.Models;
using WebApp.ViewModels.Rates;

namespace WebApp.Controllers
{
    [Authorize]
    public class RatesController : Controller
    {
        private readonly IMnbArfolyamService _mnbArfolyamService = new MnbArfolyamService();
        private readonly ILoginService _loginService = new LoginService();
        private readonly IUserRatesService _userRatesService = new UserRatesService();

        public ActionResult CurrentRates()
        {
            var currentExchangeRates = _mnbArfolyamService.GetCurrentExchangeRates();
            RatesViewModel viewModel = new RatesViewModel(currentExchangeRates);

            return View("CurrentRates", viewModel);
        }

        [HttpPost]
        public ActionResult SaveRate(SaveRateViewModel rate)
        {
            int userId = _loginService.GetUserByEmail(User.Identity.Name).Id;

            UserRate userRate = new UserRate(userId, DateTime.Now, rate.Unit, rate.Currency, rate.CurrentRate, rate.Comment);

            _userRatesService.SaveUserRate(userRate);

            return Json(true, JsonRequestBehavior.AllowGet);
        }
    }
}
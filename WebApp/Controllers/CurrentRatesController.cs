using System;
using System.Web;
using System.Web.Mvc;
using Application;
using Application.Interfaces;
using Data_Layer.Models;
using WebApp.ViewModels.Rates;

namespace WebApp.Controllers
{
    [Authorize]
    public class CurrentRatesController : Controller
    {
        private readonly IMnbArfolyamService _mnbArfolyamService = new MnbArfolyamService();
        private readonly ILoginService _loginService = new LoginService();
        private readonly IUserRatesService _userRatesService = new UserRatesService();

        public ActionResult Index()
        {
            var currentExchangeRates = _mnbArfolyamService.GetCurrentExchangeRates();
            RatesViewModel viewModel = new RatesViewModel(currentExchangeRates);

            return View("Index", viewModel);
        }

        [HttpPost]
        public ActionResult SaveRate(SaveRateViewModel rate)
        {
            if (!ModelState.IsValid)
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }

            int userId = _loginService.GetUserByEmail(User.Identity.Name).Id;
            UserRate userRate = new UserRate(userId, DateTime.Now, rate.Unit, rate.Currency, rate.CurrentRate, HttpUtility.HtmlEncode(rate.Comment));
            _userRatesService.SaveUserRate(userRate);

            return Json(true, JsonRequestBehavior.AllowGet);
        }
    }
}
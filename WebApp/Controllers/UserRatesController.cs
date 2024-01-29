using System.Collections.Generic;
using Application;
using Application.Interfaces;
using System.Web.Mvc;
using Data_Layer.Models;
using WebApp.ViewModels.UserRates;

namespace WebApp.Controllers
{
    [Authorize]
    public class UserRatesController : Controller
    {
        private readonly ILoginService _loginService = new LoginService();
        private readonly IUserRatesService _userRatesService = new UserRatesService();

        public ActionResult Index()
        {
            int userId = _loginService.GetUserByEmail(User.Identity.Name).Id;

            List<UserRate> userRates = _userRatesService.GetRelatedUserRates(userId);
            var viewModel = new UserRatesViewModel(userRates);

            return View(viewModel);
        }
    }
}
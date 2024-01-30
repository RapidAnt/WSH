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

        [HttpPost]
        public ActionResult DeleteRate(int rateId)
        {
            int userId = _loginService.GetUserByEmail(User.Identity.Name).Id;

            _userRatesService.DeleteUserRate(userId, rateId);

            // It would be better to return the status code and refresh only the UI
            return Json(Url.Action("Index"));
        }

        [HttpPost]
        public ActionResult UpdateRateComment(UserRateUpdateVivewModel model)
        {
            if (ModelState.IsValid)
            {
                int userId = _loginService.GetUserByEmail(User.Identity.Name).Id;
                _userRatesService.UpdateCommentInUserRate(userId, model.Id, model.Comment);
            }

            // It would be better to return the status code and refresh only the UI
            return Json(true, JsonRequestBehavior.AllowGet);
        }
    }
}
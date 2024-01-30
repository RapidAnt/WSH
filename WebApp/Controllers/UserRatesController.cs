using System.Collections.Generic;
using System.Threading.Tasks;
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

        public async Task<ActionResult> Index()
        {
            int userId = (await _loginService.GetUserByEmail(User.Identity.Name)).Id;

            List<UserRate> userRates = await _userRatesService.GetRelatedUserRates(userId);
            var viewModel = new UserRatesViewModel(userRates);

            return View(viewModel);
        }

        [HttpPost]
        public async Task<ActionResult> DeleteRate(int rateId)
        {
            int userId = (await _loginService.GetUserByEmail(User.Identity.Name)).Id;

            await _userRatesService.DeleteUserRate(userId, rateId);

            // It would be better to return the status code and refresh only the UI
            return Json(Url.Action("Index"));
        }

        [HttpPost]
        public async Task<ActionResult> UpdateRateComment(UserRateUpdateVivewModel model)
        {
            if (ModelState.IsValid)
            {
                int userId = (await _loginService.GetUserByEmail(User.Identity.Name)).Id;
                await _userRatesService.UpdateCommentInUserRate(userId, model.Id, model.Comment);
            }

            // It would be better to return the status code and refresh only the UI
            return Json(true, JsonRequestBehavior.AllowGet);
        }
    }
}
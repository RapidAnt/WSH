using System.Web.Mvc;
using Application;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    [Authorize]
    public class RegisterController : Controller
    {
        private IRegistrationService _registrationService = new RegistrationService();
        private ILoginService _loginService = new LoginService();

        [AllowAnonymous]
        public ActionResult Register()
        {
            return View("Register");
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid || 
                _loginService.GetUserByEmail(model.Email) != null ||
                model.Password != model.PasswordRepeated)
            {
                return View("Register");
            }

            var hash = _registrationService.GenerateHash(model.Password);

            _registrationService.RegisterUser(model.UserName, model.Email, hash);

            return RedirectToAction("Login", "Login");
        }
    }
}
using System.Threading.Tasks;
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
            return View("Index");
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid || 
                await _loginService.GetUserByEmail(model.Email) != null ||
                model.Password != model.PasswordRepeated)
            {
                return View("Index");
            }

            var hash = await _registrationService.GenerateHash(model.Password);

            await _registrationService.RegisterUser(model.UserName, model.Email, hash);

            return RedirectToAction("Login", "Login");
        }
    }
}
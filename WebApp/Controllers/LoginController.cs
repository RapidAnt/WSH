using System.Web.Mvc;
using System.Web.Security;
using Application;
using Data_Layer;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    [Authorize]
    public class LoginController : Controller
    {
        private LoginService _loginService = new LoginService();

        [AllowAnonymous]
        public ActionResult Login()
        {
            return View("Login");
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid && _loginService.CanLogIn(model.Email, model.Password))
            {
                User user = _loginService.GetUser(model.Email, model.Password);
                FormsAuthentication.SetAuthCookie(user.UserName, false);

                return RedirectToAction("Index", "Home");
            }

            return View("Login");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}
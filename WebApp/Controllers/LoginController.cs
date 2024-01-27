using System.Web.Mvc;
using System.Web.Security;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    [Authorize]
    public class LoginController : Controller
    {
        [AllowAnonymous]
        public ActionResult Login()
        {
            return View("Login");
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid && model.Email == "Email" && model.Password == "Password")
            {
                FormsAuthentication.SetAuthCookie(model.Email, false);
                return RedirectToAction("Index","Home");
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
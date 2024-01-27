using System.Reflection;
using System.Web.Mvc;
using System.Web.Security;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        [AllowAnonymous]
        public ActionResult Index()
        {
            if (!HttpContext.User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login");
            }

            //return View();
            return RedirectToAction("CurrentRates");
        }

        [AllowAnonymous]
        public ActionResult Register()
        {
            return View("Register");
        }

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Registration
            }

            return View("Register");
        }

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
                return RedirectToAction("Index");
            }

            return View("Login");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }

        public ActionResult CurrentRates()
        {
            return View("CurrentRates");
        }
    }
}
using System.Threading.Tasks;
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
        private ILoginService _loginService = new LoginService();

        [AllowAnonymous]
        public ActionResult Login()
        {
            return View("Index");
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (await _loginService.CanLogIn(model.Email, model.Password))
                {
                    User user = await _loginService.GetUserByEmailAndPassword(model.Email, model.Password);
                    FormsAuthentication.SetAuthCookie(user.Email, false);
                    System.Web.HttpContext.Current.Session["UserName"] = user.UserName;

                    return RedirectToAction("Index", "Home");
                }
            }

            return View("Index");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}
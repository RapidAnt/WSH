using System.Web.Mvc;

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
                return RedirectToAction("Login","Login");
            }

            return RedirectToAction("Index","CurrentRates");
        }
    }
}
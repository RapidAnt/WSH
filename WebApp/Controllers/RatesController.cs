using System.Web.Mvc;

namespace WebApp.Controllers
{
    [Authorize]
    public class RatesController : Controller
    {
        public ActionResult CurrentRates()
        {
            return View("CurrentRates");
        }
    }
}
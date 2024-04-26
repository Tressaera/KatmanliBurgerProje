using Microsoft.AspNetCore.Mvc;

namespace KatmanliBurger.WebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

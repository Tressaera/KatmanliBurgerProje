using Microsoft.AspNetCore.Mvc;

namespace KatmanliBurger.WebUI.Controllers
{
	public class AdminLayoutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}

using Microsoft.AspNetCore.Mvc;

namespace KatmanliBurger.WebUI.Controllers
{
	public class ErrorController : Controller
	{
		public IActionResult ErrorPage()
		{
			return View();
		}
	}
}

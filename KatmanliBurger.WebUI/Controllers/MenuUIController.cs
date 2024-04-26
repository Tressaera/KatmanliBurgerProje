using KatmanliBurger.Service.Services.MenuServices;
using Microsoft.AspNetCore.Mvc;

namespace KatmanliBurger.WebUI.Controllers
{
	public class MenuUIController : Controller
	{
		private readonly IMenuService _menuManager;

		public MenuUIController(IMenuService menuManager)
		{
			_menuManager = menuManager;
		}

		public IActionResult Index(int id)
		{
			return View(_menuManager.GetMenu(id));
		}
	}
}

using KatmanliBurger.Service.Services.OrderServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace KatmanliBurger.WebUI.Controllers
{
	[Authorize(Roles = "Admin")]
	public class OrderController : Controller
	{
		private readonly IOrderService _orderService;

		public OrderController(IOrderService orderService)
		{
			_orderService = orderService;
		}

		public IActionResult Index()
		{
			return View(_orderService.OrderWithDetailList(_orderService.GetAll().ToList()));
		}

        public IActionResult Delete(int id)
        {
            _orderService.UpdateStatus(id);
            return RedirectToAction("Index");

        }

		public IActionResult Details(int id)
		{
            return View(_orderService.OrderWithDetails(id));
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace KatmanliBurger.WebUI.ViewComponents.LayoutComponent
{
    public class _LayoutSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

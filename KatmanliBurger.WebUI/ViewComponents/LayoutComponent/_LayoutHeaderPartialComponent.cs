using Microsoft.AspNetCore.Mvc;

namespace KatmanliBurger.WebUI.ViewComponents.LayoutComponent
{
    public class _LayoutHeaderPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

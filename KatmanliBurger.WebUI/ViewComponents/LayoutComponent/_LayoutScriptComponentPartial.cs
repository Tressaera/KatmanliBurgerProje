using Microsoft.AspNetCore.Mvc;

namespace KatmanliBurger.WebUI.ViewComponents.LayoutComponent
{
    public class _LayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

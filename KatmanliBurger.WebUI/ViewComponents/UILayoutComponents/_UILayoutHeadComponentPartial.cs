using Microsoft.AspNetCore.Mvc;

namespace KatmanliBurger.WebUI.ViewComponents.UILayoutComponents
{
    public class _UILayoutHeadComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

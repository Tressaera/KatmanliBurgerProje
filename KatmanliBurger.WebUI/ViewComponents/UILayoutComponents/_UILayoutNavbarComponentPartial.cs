﻿using Microsoft.AspNetCore.Mvc;

namespace KatmanliBurger.WebUI.ViewComponents.UILayoutComponents
{
    public class _UILayoutNavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

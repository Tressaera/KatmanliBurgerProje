﻿using Microsoft.AspNetCore.Mvc;

namespace KatmanliBurger.WebUI.ViewComponents.MenuComponents
{
    public class _MenuNavbarComponentPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

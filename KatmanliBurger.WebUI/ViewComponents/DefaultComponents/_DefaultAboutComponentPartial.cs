﻿using KatmanliBurger.WebUI.Helpers;
using KatmanliBurger.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace KatmanliBurger.WebUI.ViewComponents.DefaultComponents
{
	public class _DefaultAboutComponentPartial : ViewComponent
    {
		private readonly IParameterSessionHelper _parameterSessionHelper;

		public _DefaultAboutComponentPartial(IParameterSessionHelper parameterSessionHelper)
		{
			_parameterSessionHelper = parameterSessionHelper;
		}

		public IViewComponentResult Invoke()
        {
			ParameterListViewModel model = new ParameterListViewModel() { ParameterDetails = _parameterSessionHelper.GetParameters("ParameterDetails") };
			
			return View(model);
        }
    }
}

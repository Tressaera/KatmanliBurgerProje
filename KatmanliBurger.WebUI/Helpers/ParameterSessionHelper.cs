using KatmanliBurger.Data.DomainModels;
using KatmanliBurger.Service.Services.ParameterServices;
using KatmanliBurger.WebUI.Extensions;

namespace KatmanliBurger.WebUI.Helpers
{
	public class ParameterSessionHelper : IParameterSessionHelper
	{
		IHttpContextAccessor _httpContextAccessor;
		IParameterService _parameterService;

		public ParameterSessionHelper(IHttpContextAccessor httpContextAccessor, IParameterService parameterService)
		{
			_httpContextAccessor = httpContextAccessor;
			_parameterService = parameterService;
		}
		public IEnumerable<ParameterDetail> GetParameters(string key)
		{
			var parameters = _httpContextAccessor.HttpContext.Session.GetObject<IEnumerable<ParameterDetail>>(key);
			if (parameters == null || !parameters.Any())
			{
				
				parameters = _parameterService.GetAll();
				SetParameters(key, parameters); // Session'a ekle
			}

			return parameters;
		}

		public void SetParameters(string key, IEnumerable<ParameterDetail> parameters)
		{
			_httpContextAccessor.HttpContext.Session.SetObject(key, parameters);
		}
	}
}

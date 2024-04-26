using KatmanliBurger.Data.DomainModels;

namespace KatmanliBurger.WebUI.Helpers
{
	public interface IParameterSessionHelper
	{
		IEnumerable<ParameterDetail> GetParameters(string key);
		void SetParameters(string key, IEnumerable<ParameterDetail> parameters);
	}
}

using KatmanliBurger.Data.DomainModels;

namespace KatmanliBurger.WebUI.Helpers
{
	public static class ErrorMessageProvider
	{
		private static readonly Dictionary<string, string> _errorMessages = new Dictionary<string, string>();
		public static void LoadErrorMessages(List<ParameterDetail> errorMessages)
		{
			foreach (var errorMessage in errorMessages)
			{
				_errorMessages[errorMessage.Code] = errorMessage.Description;
			}
		}

		public static string GetErrorMessage(string code)
		{
			if (_errorMessages.TryGetValue(code, out string errorMessage))
			{
				return errorMessage;
			}

			return "Default Error Message"; // Varsayılan bir hata mesajı dönebilirsiniz.
		}
	}
}

using Microsoft.AspNetCore.Http;

namespace Laba1.Extensions
{
	public static class RequestExtensions
	{
		public static bool IsAjaxRequest(this HttpRequest request)
		{
			return request
		   .Headers["x-requested-with"]
		   .Equals("XMLHttpRequest");
		}

	}
}

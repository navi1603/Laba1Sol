using Microsoft.AspNetCore.Mvc;

namespace Laba1.Views.Shared.Components
{
	public class CartViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}

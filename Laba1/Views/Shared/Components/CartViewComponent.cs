using Laba1.Extensions;
using Laba1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laba1.Views.Shared.Components
{
	public class CartViewComponent : ViewComponent
	{
		private Cart _cart;
		public CartViewComponent(Cart cart)
		{
			_cart = cart;
		}
		public IViewComponentResult Invoke()
		{
			var cart = HttpContext.Session.Get<Cart>("cart");
			return View(cart);
		}
	}
}

using Laba1.DAL.Entities;
using Laba1.DAL.Data;
using Laba1.Extensions;
using Laba1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laba1.Controllers
{
    public class ProductController : Controller
    {
        ApplicationDbContext _context;
        int _pageSize;
        private ILogger _logger;

		public ProductController(ApplicationDbContext context, ILogger<ProductController> logger)
        {
            _pageSize = 3;
            _context = context;
            _logger = logger;
        }
		[Route("Catalog")]
		[Route("Catalog/Page_{pageNo}")]
		public IActionResult Index(int? group, int pageNo = 1)
        {
            var dishesFiltered = _context.Dishes.Where(d => !group.HasValue || d.DishGroupId == group.Value);
            ViewData["Groups"] = _context.DishGroups;
            ViewData["CurrentGroup"] = group ?? 0;
            //_logger.LogInformation($"info: group={group}, page={pageNo}");
			var model = ListViewModel<Dish>.GetModel(dishesFiltered, pageNo, _pageSize);
			if (Request.IsAjaxRequest())
				return PartialView("_listpartial", model);
			else
				return View(model);
		}

		
    }
    
}

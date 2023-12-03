using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Laba1.DAL.Data;
using Laba1.DAL.Entities;

namespace Laba1.Areas.Admin.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly Laba1.DAL.Data.ApplicationDbContext _context;

        public DetailsModel(Laba1.DAL.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Dish Dish { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Dishes == null)
            {
                return NotFound();
            }

            var dish = await _context.Dishes.FirstOrDefaultAsync(m => m.DishId == id);
            if (dish == null)
            {
                return NotFound();
            }
            else 
            {
                Dish = dish;
            }
            return Page();
        }
    }
}

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
    public class IndexModel : PageModel
    {
        private readonly Laba1.DAL.Data.ApplicationDbContext _context;

        public IndexModel(Laba1.DAL.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Dish> Dish { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Dishes != null)
            {
                Dish = await _context.Dishes
                .Include(d => d.Group).ToListAsync();
            }
        }
    }
}

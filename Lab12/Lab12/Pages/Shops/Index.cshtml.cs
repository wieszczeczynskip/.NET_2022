using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lab12.Data;
using Lab12.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Lab12.Pages.Shops
{
    public class IndexModel : PageModel
    {
        private readonly Lab12.Data.MyDbContext _context;

        public IndexModel(Lab12.Data.MyDbContext context)
        {
            _context = context;
        }

        public IList<Article> Article { get; set; }


        [BindProperty(SupportsGet = true)]
        public int? Id { get; set; }

        public Category Category { get; set; }


        public async Task<IActionResult> OnGetAsync()
        {
            ViewData["Categories"] = new SelectList(_context.Category, "Id", "Name");
            if (Id == null)
            {
                Article = await _context.Article.Include(a => a.Category).ToListAsync();
                ViewData["Current"] = null;
                return Page();
            }
            else
            {
                Category = await _context.Category.FirstOrDefaultAsync(m => m.Id == Id);

                Article = await _context.Article
                    .Include(a => a.Category).Where(a => a.CategoryId == Category.Id).ToListAsync();


                ViewData["Current"] = Id;

                return Page();
            }
        }




    }
}
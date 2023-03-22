using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lab12.Data;
using Lab12.Models;

namespace Lab12.Pages.Categories
{
    public class DeleteModel : PageModel
    {
        private readonly Lab12.Data.MyDbContext _context;

        private string defaultImagePath;

        public DeleteModel(Lab12.Data.MyDbContext context)
        {
            _context = context;
            defaultImagePath = "image/noimage.png";
        }

        [BindProperty]
        public Category Category { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category = await _context.Category.FirstOrDefaultAsync(m => m.Id == id);

            if (Category == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Category = await _context.Category.FindAsync(id);
            var articles = _context.Article.Where(x => x.CategoryId == Category.Id).ToList();
            foreach (Article article in articles)
            {
                if (!article.filePath.Equals(defaultImagePath))
                {
                    System.IO.File.Delete("wwwroot/" + article.filePath);
                }
            }

            if (Category != null)
            {
                _context.Category.Remove(Category);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

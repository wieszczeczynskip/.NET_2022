using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lab12.Data;
using Lab12.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;



namespace Lab12.Pages.Articles
{
    public class DeleteModel : PageModel
    {
        private readonly Lab12.Data.MyDbContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;
        
        private string defaultImagePath;

        public DeleteModel(Lab12.Data.MyDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
            defaultImagePath = "image/noimage.png";

        }
        [BindProperty]
        public Article Article { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Article = await _context.Article
                .Include(a => a.Category).FirstOrDefaultAsync(m => m.Id == id);

            if (Article == null)
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

            Article = await _context.Article.FindAsync(id);

            if (Article != null)
            {
                if (!Article.filePath.Equals(defaultImagePath))
                {
                    System.IO.File.Delete("wwwroot/" + Article.filePath);
                }
                _context.Article.Remove(Article);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}

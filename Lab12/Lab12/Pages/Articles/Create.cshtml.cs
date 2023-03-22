using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Lab12.Data;
using Lab12.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace Lab12.Pages.Articles
{
    public class CreateModel : PageModel
    {
        private readonly Lab12.Data.MyDbContext _context;
        private readonly IHostingEnvironment _hostingEnvironment;

        private string uploadFolderPath;
        private string uploadFolder;
        private string defaultImagePath;

        public CreateModel(Lab12.Data.MyDbContext context, IHostingEnvironment hostingEnvironment)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
            uploadFolderPath = "wwwroot/upload/";
            uploadFolder = "upload/";
            defaultImagePath = "image/noimage.png";
        }

        public IActionResult OnGet()
        {
            ViewData["CategoryId"] = new SelectList(_context.Category, "Id", "Name");
            return Page();
        }

        [BindProperty]
        public Article Article { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (Article.FormFile != null)
            {
                var guid = Guid.NewGuid().ToString();
                var fileExtension = Path.GetExtension(Article.FormFile.FileName);
                FileStream fs = new FileStream(uploadFolderPath + guid + fileExtension, FileMode.Create);
                Article.FormFile.CopyTo(fs);
                fs.Close();
                Article.filePath = uploadFolder + guid + fileExtension;
            }
            else
            {
                Article.filePath = defaultImagePath;
            }

            _context.Article.Add(Article);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
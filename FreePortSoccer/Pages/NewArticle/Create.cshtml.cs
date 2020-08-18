using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FreePortSoccer.Models;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace FreePortSoccer.Pages.NewArticle
{
    public class CreateModel : PageModel
    {
        private readonly FreePortSoccer.Models.SoccerContext _context;

        public CreateModel(FreePortSoccer.Models.SoccerContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public News News { get; set; }
        [BindProperty]
        public IFormFile Image { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (Image != null)
            {
                using (var stream = new MemoryStream())
                {
                    await Image.CopyToAsync(stream);
                    News.Image = stream.ToArray();
                    News.ImageContentType = Image.ContentType;
                }
            }

            _context.News.Add(News);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

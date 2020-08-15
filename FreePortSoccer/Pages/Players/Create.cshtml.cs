using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;
using FreePortSoccer.Models;
using System.IO;

namespace FreePortSoccer.Pages.Players
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
            ViewData["PositionId"] = new SelectList(_context.Positions, "PositionId", "PositionDes");
            return Page();
        }

        [BindProperty]
        public Player Player { get; set; }
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

            Player.InsertedDate = DateTime.UtcNow;
            Player.ModifiedDate = DateTime.UtcNow;

            if(Image != null)
            {
                using(var stream = new MemoryStream())
                {
                    await Image.CopyToAsync(stream);
                    Player.Image = stream.ToArray();
                    Player.ImageContentType = Image.ContentType;
                }
            }

            _context.Players.Add(Player);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}

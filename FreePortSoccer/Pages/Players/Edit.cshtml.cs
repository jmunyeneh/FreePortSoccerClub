using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FreePortSoccer.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace FreePortSoccer.Pages.Players
{
    public class EditModel : PageModel
    {
        private readonly FreePortSoccer.Models.SoccerContext _context;

        public EditModel(FreePortSoccer.Models.SoccerContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Player Player { get; set; }
        [BindProperty]
        public IFormFile Image { get; set; }
        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Player = await _context.Players
                .Include(p => p.position).FirstOrDefaultAsync(m => m.PlayerId == id);

            if (Player == null)
            {
                return NotFound();
            }
           ViewData["PositionId"] = new SelectList(_context.Positions, "PositionId", "PositionDes");
            return Page();
        }
        
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
                       
            Player.ModifiedDate = DateTime.Now;
            

            if (Image != null) {
                using (var stream = new MemoryStream())
                {
                    await Image.CopyToAsync(stream);

                    Player.Image = stream.ToArray();
                    Player.ImageContentType = Image.ContentType;
                }
            }

            _context.Attach(Player).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlayerExists(Player.PlayerId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PlayerExists(long id)
        {
            return _context.Players.Any(e => e.PlayerId == id);
        }
    }
}

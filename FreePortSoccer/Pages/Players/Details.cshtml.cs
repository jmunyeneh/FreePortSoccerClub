using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FreePortSoccer.Models;

namespace FreePortSoccer.Pages.Players
{
    public class DetailsModel : PageModel
    {
        private readonly FreePortSoccer.Models.SoccerContext _context;

        public DetailsModel(FreePortSoccer.Models.SoccerContext context)
        {
            _context = context;
        }

        public Player Player { get; set; }

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
            return Page();
        }
    }
}

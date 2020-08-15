using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FreePortSoccer.Models;

namespace FreePortSoccer.Pages.Postions
{
    public class IndexModel : PageModel
    {
        private readonly FreePortSoccer.Models.SoccerContext _context;

        public IndexModel(FreePortSoccer.Models.SoccerContext context)
        {
            _context = context;
        }

        public IList<Position> Position { get;set; }

        public async Task OnGetAsync()
        {
            Position = await _context.Positions.ToListAsync();
        }
    }
}

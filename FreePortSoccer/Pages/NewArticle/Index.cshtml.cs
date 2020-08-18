using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FreePortSoccer.Models;

namespace FreePortSoccer.Pages.NewArticle
{
    public class IndexModel : PageModel
    {
        private readonly FreePortSoccer.Models.SoccerContext _context;

        public IndexModel(FreePortSoccer.Models.SoccerContext context)
        {
            _context = context;
        }

        public IList<News> News { get;set; }

        public async Task OnGetAsync()
        {
            News = await _context.News.ToListAsync();
        }
    }
}

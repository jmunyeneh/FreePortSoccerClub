﻿using System;
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

namespace FreePortSoccer.Pages.NewArticle
{
    public class EditModel : PageModel
    {
        private readonly FreePortSoccer.Models.SoccerContext _context;

        public EditModel(FreePortSoccer.Models.SoccerContext context)
        {
            _context = context;
        }

        [BindProperty]
        public News News { get; set; }
        [BindProperty]
        public IFormFile Image { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            News = await _context.News.FirstOrDefaultAsync(m => m.Id == id);

            if (News == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(News).State = EntityState.Modified;

            if (News.Image == null)
            {
                var databaseValues = _context.Entry(News).GetDatabaseValues();
                News.Image = (byte[])databaseValues["Image"];
                News.ImageContentType = (string)databaseValues["ImageContentType"];
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

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NewsExists(News.Id))
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

        private bool NewsExists(int id)
        {
            return _context.News.Any(e => e.Id == id);
        }
    }
}

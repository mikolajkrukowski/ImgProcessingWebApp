using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ImgProcessingWebApp.Data;
using ImgProcessingWebApp.Models;

namespace ImgProcessingWebApp.Pages.Images
{
    public class DetailsModel : PageModel
    {
        private readonly ImgProcessingWebApp.Data.ImgProcessingWebAppContext _context;

        public DetailsModel(ImgProcessingWebApp.Data.ImgProcessingWebAppContext context)
        {
            _context = context;
        }

        public Image Image { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var image = await _context.Image.FirstOrDefaultAsync(m => m.Id == id);
            if (image == null)
            {
                return NotFound();
            }
            else
            {
                Image = image;
            }
            return Page();
        }
    }
}

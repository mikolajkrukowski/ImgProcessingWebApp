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
    public class IndexModel : PageModel
    {
        private readonly ImgProcessingWebApp.Data.ImgProcessingWebAppContext _context;

        public IndexModel(ImgProcessingWebApp.Data.ImgProcessingWebAppContext context)
        {
            _context = context;
        }

        public IList<Image> Image { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Image = await _context.Image.ToListAsync();
        }
    }
}

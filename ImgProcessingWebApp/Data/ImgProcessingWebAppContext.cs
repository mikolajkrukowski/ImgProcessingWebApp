using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ImgProcessingWebApp.Models;

namespace ImgProcessingWebApp.Data
{
    public class ImgProcessingWebAppContext : DbContext
    {
        public ImgProcessingWebAppContext (DbContextOptions<ImgProcessingWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<ImgProcessingWebApp.Models.Image> Image { get; set; } = default!;
    }
}

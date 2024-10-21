using ImgProcessingWebApp.Data;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Formats.Asn1.AsnWriter;

namespace ImgProcessingWebApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ImgProcessingWebAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ImgProcessingWebAppContext>>()))
            {
                if (context == null || context.Image == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.Image.Any())
                {
                    return;   // DB has been seeded
                }

                context.Image.AddRange(
                    new Image
                    {
                        Name = "Landscape",
                        Dir = "/Imgs/1.jpg"
                    }



                );
                context.SaveChanges();
            }
        }
    }
}
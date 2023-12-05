using GDC.Data;
using Microsoft.EntityFrameworkCore;

namespace GDC.Models
{
    public class Seed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.Category.Any() || context.Contact.Any()) //Look for any categories
                {
                    return; //DB has been seeded
                }

                context.Category.AddRange(
                    new Category
                    {
                        name = "Famille"
                    },
                    new Category
                    {
                        name = "Ami"
                    },
                    new Category
                    {
                        name = "Collegue"
                    },
                    new Category
                    {
                        name = "Soi-Meme"
                    });
                context.SaveChanges();

            }
        }
    }
}

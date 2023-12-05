using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using GDC.Models;

namespace GDC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<GDC.Models.Category>? Category { get; set; }
        public DbSet<GDC.Models.Contact>? Contact { get; set; }
    }
}
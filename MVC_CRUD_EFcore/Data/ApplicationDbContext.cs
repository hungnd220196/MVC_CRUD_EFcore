using Microsoft.EntityFrameworkCore;
using MVC_CRUD_EFcore.Models.Entities;

namespace MVC_CRUD_EFcore.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Student> Students { get; set; }

    }
}

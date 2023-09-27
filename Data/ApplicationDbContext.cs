using Microsoft.EntityFrameworkCore;
using WebCoba.Models;

namespace WebCoba.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "action", DisplayOrder = 1 },
                new Category { Id = 3, Name = "sci-fi", DisplayOrder = 2 },
                new Category { Id = 4, Name = "history", DisplayOrder = 3 },
                new Category { Id = 5, Name = "batman", DisplayOrder = 4 });
        }
    }
}

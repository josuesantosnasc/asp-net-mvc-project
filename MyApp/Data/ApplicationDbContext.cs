using Microsoft.EntityFrameworkCore;
using MyApp.Models;

namespace MyApp.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        
        }

        public DbSet<DiaryEntry>DiaryEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DiaryEntry>().HasData(
                    new DiaryEntry { Id=1,Title="Went Hiking",Content="Went",Created= new DateTime(2025, 4, 29) },
                    new DiaryEntry { Id = 2, Title = "Went Shopping", Content = "Shopping", Created = new DateTime(2025, 4, 29) },
                     new DiaryEntry { Id = 3, Title = "Went Diadema", Content = "Diadema", Created = new DateTime(2025, 4, 29) }
             );
        }
    }
}

using Microsoft.EntityFrameworkCore;
using BlazorApp1.Models;

namespace BlazorApp1.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Osoba> Osoby { get; set; }
        public DbSet<Plec> SlownikPlec { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Osoba>()
                .ToTable("osoba");
            modelBuilder.Entity<Plec>().HasData(
                new Plec { Id = 1, Nazwa = "Mężczyzna" },
                new Plec { Id = 2, Nazwa = "Kobieta" },
                new Plec { Id = 3, Nazwa = "Inna" }
            );
        }

    }
}
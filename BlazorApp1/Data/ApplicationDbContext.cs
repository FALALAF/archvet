using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BlazorApp1.Models;

namespace BlazorApp1.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Twoje istniejące tabele
        public DbSet<Osoba> Osoby { get; set; }
        public DbSet<Plec> SlownikPlec { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // WAŻNE! To musi być na początku

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
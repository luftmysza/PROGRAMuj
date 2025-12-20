using Aplikacja.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;




namespace Aplikacja.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Kurs> Kursy { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Kurs>().HasData(
                new Kurs
                {
                    Id = 1,
                    Tytul = "Wstęp do C#",
                    Opis = "Poznaj podstawy języka C# i platformy .NET",
                    JezykProgramowania = "C#",
                    Cena = 0m
                },
                new Kurs
                {
                    Id = 2,
                    Tytul = "Java dla opornych",
                    Opis = "Obiektowość w praktyce i wzorce projektowe",
                    JezykProgramowania = "Java",
                    Cena = 49.99m
                },
                new Kurs
                {
                    Id = 3,
                    Tytul = "HTML & CSS - Budowa stron",
                    Opis = "Jak stworzyć swoją pierwszą stronę w 15 minut",
                    JezykProgramowania = "HTML/CSS",
                    Cena = 0m
                },
                new Kurs
                {
                    Id = 4,
                    Tytul = "Python Data Science",
                    Opis = "Analiza danych z biblioteką Pandas",
                    JezykProgramowania = "Python",
                    Cena = 99.00m
                }
            );
        }
    }
}

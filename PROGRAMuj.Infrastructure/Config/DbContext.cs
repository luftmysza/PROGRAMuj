// Initial version ADR 07.12.2025
// Upd DMI 19.12.2025
// Upd DMI 21.12.2025

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using PROGRAMuj.Core.Models;

namespace PROGRAMuj.Infrastructure.Config;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

    public DbSet<Course> Courses { get; set; }
    public DbSet<User> Users { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        User usr1 = new User
        {
            Id = 1,
            Name = "Jane Roe"
        };
        User usr2 = new User
        {
            Id = 2,
            Name = "Alex Smith"
        };
        User usr3 = new User
        {
            Id = 3,
            Name = "Chris Miller"
        };
        User usr4 = new User
        {
            Id = 4,
            Name = "Pat Taylor"
        };
        
        modelBuilder.Entity<User>().HasData(
            usr1,
            usr2,
            usr3,
            usr4
        );
       
        modelBuilder.Entity<Course>()
            .HasMany(c => c.Participants)
            .WithMany();
        
        modelBuilder.Entity<Course>()
            .HasData(
                new Course
                {
                    Id = 1,
                    Title = "Wstęp do C#",
                    Desc = "Poznaj podstawy języka C# i platformy .NET",
                    ProgLang = "C#",
                    Price = 0m,
                    AuthorId = usr1.Id
                },
                new Course
                {
                    Id = 2,
                    Title = "Java dla opornych",
                    Desc = "Obiektowość w praktyce i wzorce projektowe",
                    ProgLang = "Java",
                    Price = 49.99m,
                    AuthorId = usr2.Id
                },
                new Course
                {
                    Id = 3,
                    Title = "HTML & CSS - Budowa stron",
                    Desc = "Jak stworzyć swoją pierwszą stronę w 15 minut",
                    ProgLang = "HTML/CSS",
                    Price = 0m,
                    AuthorId = usr3.Id
                },
                new Course
                {
                    Id = 4,
                    Title = "Python Data Science",
                    Desc = "Analiza danych z biblioteką Pandas",
                    ProgLang = "Python",
                    Price = 99.00m,
                    AuthorId = usr4.Id
                }
        );

        modelBuilder.Entity("CourseUser")
            .HasData(
                new { CourseId = 1, ParticipantsId = 1 },
                new { CourseId = 1, ParticipantsId = 2 },
                new { CourseId = 1, ParticipantsId = 3 },
                new { CourseId = 1, ParticipantsId = 4 },
                new { CourseId = 2, ParticipantsId = 1 },
                new { CourseId = 2, ParticipantsId = 2 },
                new { CourseId = 2, ParticipantsId = 3 },
                new { CourseId = 2, ParticipantsId = 4 },
                new { CourseId = 3, ParticipantsId = 1 },
                new { CourseId = 3, ParticipantsId = 2 },
                new { CourseId = 3, ParticipantsId = 3 },
                new { CourseId = 3, ParticipantsId = 4 },
                new { CourseId = 4, ParticipantsId = 1 },
                new { CourseId = 4, ParticipantsId = 2 },
                new { CourseId = 4, ParticipantsId = 3 },
                new { CourseId = 4, ParticipantsId = 4 }
        );
    }
}

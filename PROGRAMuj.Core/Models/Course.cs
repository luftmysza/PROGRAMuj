// Initial version ADR 07.12.2025
// Upd DMI 19.12.2025

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PROGRAMuj.Core.Models;

public class Course
{
    [Key]
    public int Id { get; set; }
    [Display(Name = "Tytuł")]
    public string? Title { get; set; }
    [Display(Name = "Opis")]
    public string? Desc { get; set; }
    [Display(Name = "Język programowania")]
    public string ProgLang { get; set; } = "";
    [Display(Name = "Cena")]
    public decimal Price { get; set; } = 0m;
    [Display(Name = "Twórca")]
    public int AuthorId { get; set; } 
    public User Author { get; set; } = null!;
    [Display(Name = "Stworzony")]
    public DateOnly CreatedDate { get; set; } = DateOnly.FromDateTime(DateTime.Today);
    [Display(Name = "Ostatnio aktualizowany")]
    public DateOnly UpdatedDate { get; set; } = DateOnly.FromDateTime(DateTime.Today);
    public ICollection<User>? Participants { get; set; } = new List<User>();

    // public ICollection<Lesson> Lessons { get; set; }
    // public Task Task { get; set; }
    // -- ewentualna relacja U�ytkownik - Kurs
}
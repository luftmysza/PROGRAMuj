// Initial Version DMI 19.12

using System.ComponentModel.DataAnnotations;

namespace PROGRAMuj.Models;

public class User
{
    [Key]
    public int Id { get; set; }
    [Display(Name = "Imię")]
    public string? Name { get; set; }
    [Display(Name = "Dołączył(a)")]
    public DateOnly Joined { get; set; } = DateOnly.FromDateTime(DateTime.Today);
    
}

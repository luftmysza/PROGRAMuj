namespace Aplikacja.Models
{
    public class Kurs
    {
        public int Id { get; set; }
        public string Tytul { get; set; }
        public string Opis { get; set; }
        public string JezykProgramowania { get; set; }
        public decimal Cena { get; set; }


        // public ICollection<Lekcja> Lekcje { get; set; }
        // public Zadanie Zadanie { get; set; }
        
        
        // -- ewentualna relacja U¿ytkownik - Kurs
        // public ICollection<Uzytkownik> Uczestnicy { get; set; }

    }
}

namespace komponentova_tvorba.Models;

public class Author : User
{
    public DateOnly BirthDate { get; set; }
    public DateOnly? DeathDate { get; set; }

    public bool isAlive()
    {
        return DeathDate == null;
    }

    public int Age()
    {
        var currentYear = DateOnly.FromDateTime(DateTime.Now).Year;
        var deathDate = DeathDate ?? DateOnly.FromDateTime(DateTime.Now);
        return isAlive() ? currentYear - BirthDate.Year : deathDate.Year - BirthDate.Year;
    }

    public ICollection<Book> Books { get; set; }
}

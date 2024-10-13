using komponentova_tvorba.Models;

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
        return isAlive() ? DateOnly.FromDateTime(DateTime.Now).Year - BirthDate.Year : currentYear - BirthDate.Year;
    }
}

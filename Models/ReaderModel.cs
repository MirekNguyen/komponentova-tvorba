namespace komponentova_tvorba.Models;

public class Reader : User
{
    public string Fullname => $"{Firstname} {Surname}";
    public ICollection<Loan>? Loans { get; set; }
}

namespace komponentova_tvorba.Models;

public class Loan
{
    public int Id { get; set; }
    public required Book[] Books { get; set; }
    public DateOnly LoanDate { get; set; }
    public DateOnly? ReturnDate { get; set; }
    public DateOnly DueDate { get; set; }
    public int Amount { get; set; }
}

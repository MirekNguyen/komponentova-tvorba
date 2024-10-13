namespace komponentova_tvorba.Models;

public class Book
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string ISBN { get; set; }
    public DateOnly Published { get; set; }
}

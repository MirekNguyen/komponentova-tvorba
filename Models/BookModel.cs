namespace komponentova_tvorba.Models;

public class Book
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public string? ISBN { get; set; }
    public required DateOnly Published { get; set; }
    public required Author Author { get; set; }
}

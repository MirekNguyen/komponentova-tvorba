namespace komponentova_tvorba.Models;

public class HomeViewModel
{
    public required IEnumerable<Author> Authors { get; set; }
    public required IEnumerable<Book> Books { get; set; }
}

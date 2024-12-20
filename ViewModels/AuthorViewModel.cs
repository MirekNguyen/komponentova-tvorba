using komponentova_tvorba.Models;

namespace komponentova_tvorba.ViewModels;

public class AuthorViewModel
{
    public required IEnumerable<Author> Authors { get; set; }
    public required IEnumerable<Book> Books { get; set; }
}

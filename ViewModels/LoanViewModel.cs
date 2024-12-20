using komponentova_tvorba.Models;

namespace komponentova_tvorba.ViewModels;

public class LoanViewModel
{
    public required IEnumerable<Author> Authors { get; set; }
    public required IEnumerable<Book> Books { get; set; }
    public IEnumerable<Loan> Loans { get; set; } = Enumerable.Empty<Loan>();
}

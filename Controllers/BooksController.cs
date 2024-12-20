using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using komponentova_tvorba.Models;
using Microsoft.EntityFrameworkCore;
using komponentova_tvorba.ViewModels;

namespace komponentova_tvorba.Controllers;

public class BooksController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _context;

    public BooksController(ILogger<HomeController> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var authors = await _context.Authors.ToListAsync();
        var books = await _context.Books.ToListAsync();
        var viewModel = new HomeViewModel
        {
            Authors = authors,
            Books = books
        };

        return View(viewModel);
    }


    public async Task<IActionResult> Borrow(int id)
    {
        var book = await _context.Books.FindAsync(id);
        var reader = await _context.Readers.FindAsync(1);
        if (book == null)
        {
            return NotFound("Book not found");
        }
        if (reader == null)
        {
            return NotFound("Reader not found.");
        }

        var loan = new Loan
        {
            Book = book,
            Reader = reader,
            LoanDate = DateOnly.FromDateTime(DateTime.UtcNow),
            DueDate = DateOnly.FromDateTime(DateTime.UtcNow.AddDays(14)),
            Amount = 1
        };
        _context.Loans.Add(loan);
        await _context.SaveChangesAsync();
        return RedirectToAction("Index", "Loans");
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

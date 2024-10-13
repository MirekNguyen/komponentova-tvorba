using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using komponentova_tvorba.Models;
using Microsoft.EntityFrameworkCore;

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
        foreach (var author in authors)
        {
            Console.WriteLine($"ID: {author.Id}, Username: {author.Username}, Email: {author.Email}");
        }
        var books = await _context.Books.ToListAsync();
        var viewModel = new HomeViewModel
        {
            Authors = authors,
            Books = books
        };

        return View(viewModel);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using komponentova_tvorba.ViewModels;

namespace komponentova_tvorba.Controllers;

public class AuthorsController : Controller
{
    private readonly ILogger<AuthorsController> _logger;
    private readonly AppDbContext _context;

    public AuthorsController(ILogger<AuthorsController> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var authors = await _context.Authors.ToListAsync();
        var books = await _context.Books.ToListAsync();
        var viewModel = new AuthorViewModel
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

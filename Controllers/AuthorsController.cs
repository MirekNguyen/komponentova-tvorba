using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using komponentova_tvorba.Models;
using Microsoft.EntityFrameworkCore;

namespace komponentova_tvorba.Controllers;

public class AuthorsController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _context;

    public AuthorsController(ILogger<HomeController> logger, AppDbContext context)
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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

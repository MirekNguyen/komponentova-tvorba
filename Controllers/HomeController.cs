using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using komponentova_tvorba.Models;
using Microsoft.EntityFrameworkCore;

namespace komponentova_tvorba.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly AppDbContext _context;

    public HomeController(ILogger<HomeController> logger, AppDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        var users = await _context.Users.ToListAsync();
        foreach (var user in users)
        {
            Console.WriteLine($"ID: {user.Id}, Username: {user.Username}, Email: {user.Email}");
        }
        return View(users);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult TestExample()
    {
        return View();
    }

    // POST: Home/Create
    public async Task<IActionResult> Create(User user)
    {
        Console.WriteLine("Creating user");
        return RedirectToAction(nameof(Index));
        /*if (ModelState.IsValid)*/
        /*{*/
        /*    _context.Add(user);*/
        /*    await _context.SaveChangesAsync();*/
        /*    return RedirectToAction(nameof(Index));*/
        /*}*/
        /*return View(user);*/
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

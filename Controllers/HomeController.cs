using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LLoading.Models;
using Microsoft.EntityFrameworkCore;

namespace LLoading.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly ApplicationDbContext _context;
    public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        var user = _context.Users.FirstOrDefault(x => x.Id == 1);
        var post = user?.Post?.FirstOrDefault();
        //System.Diagnostics.Trace.WriteLine(user?.ToString());
        return View(post);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

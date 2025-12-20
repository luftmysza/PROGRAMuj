using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using PROGRAMuj.Models;
using PROGRAMuj.Data;

namespace PROGRAMuj.Controllers;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;
    
    public HomeController(ApplicationDbContext context)
    {
        _context = context;
    }
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var dbData = new DashboardData
        {
            TrendingCourses = await _context.Courses.Take(10).ToListAsync(),
            HighestRankingUsers = await _context.Users.Take(10).ToListAsync()
        };

        return View(dbData);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

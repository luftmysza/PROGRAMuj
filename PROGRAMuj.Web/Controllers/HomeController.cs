// Initial version ADR 07.12.2025
// Upd DMI 19.12.2025
// Upd DMI 21.12.2025

using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// using PROGRAMuj.Core.Models;
using PROGRAMuj.Application.Interfaces;
using PROGRAMuj.Application.DTOs;

namespace PROGRAMuj.Controllers;

public class HomeController : Controller
{
    private readonly IUserRepo _users;
    private readonly ICourseRepo _courses;
    
    public HomeController(IUserRepo users, ICourseRepo courses)
    {
        _users = users;
        _courses = courses;
    }
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var dbData = new DashboardData
        {
            TrendingCourses = await _courses.All.Take(10).ToListAsync(),
            HighestRankingUsers = await _users.All.Take(10).ToListAsync()
        };

        return View(dbData);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

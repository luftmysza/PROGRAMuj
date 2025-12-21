// Initial version DMI 19.12.2025

using PROGRAMuj.Core.Models;

namespace PROGRAMuj.Application.DTOs;

public class DashboardData
{
    public IEnumerable<Course>? TrendingCourses { get; set; }
    public IEnumerable<User>? HighestRankingUsers { get; set; }
}

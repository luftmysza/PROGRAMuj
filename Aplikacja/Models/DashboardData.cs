using System;

namespace PROGRAMuj.Models;

public class DashboardData
{
    public IEnumerable<Course>? TrendingCourses { get; set; }
    public IEnumerable<User>? HighestRankingUsers { get; set; }
}

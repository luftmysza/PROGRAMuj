// Initial version DMI 21.12.2025

using System;

using Microsoft.EntityFrameworkCore;

using PROGRAMuj.Application.Interfaces;
using PROGRAMuj.Core.Models;
using PROGRAMuj.Infrastructure.Config;

namespace PROGRAMuj.Infrastructure.Repos;

public class CourseRepo : ICourseRepo
{
    private readonly ApplicationDbContext _context;
    public CourseRepo(ApplicationDbContext context)
    {
        _context = context;
    }
    public DbSet<Course> All => _context.Courses;

    public Task AddAsync(Course? course)
    {
        throw new NotImplementedException();
    }

    public Task<Course?> FindAsync(int? id)
    {
        throw new NotImplementedException();
    }

    public Task RemoveAsync(Course? course)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(Course? course)
    {
        throw new NotImplementedException();
    }
}

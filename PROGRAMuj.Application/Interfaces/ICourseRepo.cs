// Initial version DMI 21.12.2025

using System;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using PROGRAMuj.Core.Models;

namespace PROGRAMuj.Application.Interfaces;

public interface ICourseRepo
{
    public DbSet<Course> All { get; } 
    public Task AddAsync(Course? course);
    public Task UpdateAsync(Course? course);
    public Task RemoveAsync(Course? course);
    public Task<Course?> FindAsync(int? id);
}

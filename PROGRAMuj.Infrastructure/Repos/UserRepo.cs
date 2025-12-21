// Initial version DMI 21.12.2025

using System;

using Microsoft.EntityFrameworkCore;

using PROGRAMuj.Application.Interfaces;
using PROGRAMuj.Core.Models;
using PROGRAMuj.Infrastructure.Config;

namespace PROGRAMuj.Infrastructure.Repos;

public class UserRepo : IUserRepo
{
    private readonly ApplicationDbContext _context;
    public UserRepo(ApplicationDbContext context)
    {
        _context = context;
    }
    public DbSet<User> All => _context.Users;
}

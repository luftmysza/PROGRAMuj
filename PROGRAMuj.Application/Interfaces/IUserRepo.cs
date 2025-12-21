// Initial version DMI 21.12.2025

using System;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using PROGRAMuj.Core.Models;

namespace PROGRAMuj.Application.Interfaces;

public interface IUserRepo
{
    public DbSet<User> All { get; } 
}

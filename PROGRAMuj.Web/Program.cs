// Initial version ADR 07.12.2025
// Upd DMI 19.12.2025
// Upd DMI 21.12.2025

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using PROGRAMuj.Application.Interfaces;
using PROGRAMuj.Infrastructure.Config;
using PROGRAMuj.Infrastructure.Repos;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseInMemoryDatabase("AppDb"));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddDefaultIdentity<IdentityUser>(options => 
    options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IUserRepo,UserRepo>();
builder.Services.AddScoped<ICourseRepo,CourseRepo>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<ApplicationDbContext>();

    context.Database.EnsureCreated();
}

if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseStaticFiles();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();
app.Run();
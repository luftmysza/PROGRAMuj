using System.Diagnostics;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

using PROGRAMuj.Data;
using PROGRAMuj.Models;

namespace PROGRAMuj.Controllers;

public class CourseController : Controller
{
    private readonly ApplicationDbContext _context;

    public CourseController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: Course
    public async Task<IActionResult> Index()
    {
        var applicationDbContext = _context.Courses.Include(c => c.Author);
        return View(await applicationDbContext.ToListAsync());
    }

    // GET: Course/Details/5
    [HttpGet]
    public async Task<ActionResult> Details([FromRoute] int id)
{
    Course? course = await _context.Courses.Include(c => c.Participants).FirstOrDefaultAsync(c => c.Id == id);
    return View(course);
}

    // GET: Course/Create
    public IActionResult Create()
    {
        ViewData["AuthorId"] = new SelectList(_context.Users, "Id", "Id");
        return View();
    }

    // POST: Course/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Title,Desc,ProgLang,Price")] Course course)
    {
        if (ModelState.IsValid)
        {
            CourseEnrich(course);
            _context.Add(course);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        ViewData["AuthorId"] = new SelectList(_context.Users, "Id", "Id", course.AuthorId);
        return View(course);
    }

    // GET: Course/Edit/5
    public async Task<IActionResult> Edit(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var course = await _context.Courses.FindAsync(id);
        if (course == null)
        {
            return NotFound();
        }
        ViewData["AuthorId"] = new SelectList(_context.Users, "Id", "Id", course.AuthorId);
        return View(course);
    }

    // POST: Course/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Desc,ProgLang,Price,AuthorId,CreatedDate,UpdatedDate")] Course course)
    {
        if (id != course.Id)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(course);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await CourseExists(course.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        ViewData["AuthorId"] = new SelectList(_context.Users, "Id", "Id", course.AuthorId);
        return View(course);
    }

    // GET: Course/Delete/5
    public async Task<IActionResult> Delete(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var course = await _context.Courses
            .Include(c => c.Author)
            .FirstOrDefaultAsync(m => m.Id == id);
        if (course == null)
        {
            return NotFound();
        }

        return View(course);
    }

    // POST: Course/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var course = await _context.Courses.FindAsync(id);
        if (course != null)
        {
            _context.Courses.Remove(course);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private async Task<bool> CourseExists(int id)
    {
        return await _context.Courses.AnyAsync(e => e.Id == id);
    }
    private void CourseEnrich(Course course)
    {
        // DMI: TBD kiedy będzie Identity
        course.AuthorId = 1; 
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

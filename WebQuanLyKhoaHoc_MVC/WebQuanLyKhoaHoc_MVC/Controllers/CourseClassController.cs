using learnMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace learnMVC.Controllers
{
    public class CourseClassController : Controller
    {
        private readonly AppDbContext _context;
        public CourseClassController(AppDbContext context) => _context = context;

        public async Task<IActionResult> Index()
        {
            var classes = _context.CourseClasses.Include(c => c.Course).Include(c => c.Teacher);
            return View(await classes.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            var courseClass = await _context.CourseClasses
                .Include(c => c.Course)
                .Include(c => c.Teacher)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (courseClass == null) return NotFound();
            return View(courseClass);
        }

        public IActionResult Create()
        {
            ViewBag.CourseId = new SelectList(_context.Courses, "Id", "CourseName");
            ViewBag.TeacherId = new SelectList(_context.Teachers, "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CourseClass courseClass)
        {
            if (ModelState.IsValid)
            {
                _context.Add(courseClass);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.CourseId = new SelectList(_context.Courses, "Id", "CourseName", courseClass.CourseId);
            ViewBag.TeacherId = new SelectList(_context.Teachers, "Id", "Name", courseClass.TeacherId);
            return View(courseClass);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var courseClass = await _context.CourseClasses.FindAsync(id);
            if (courseClass == null) return NotFound();

            ViewBag.CourseId = new SelectList(_context.Courses, "Id", "CourseName", courseClass.CourseId);
            ViewBag.TeacherId = new SelectList(_context.Teachers, "Id", "Name", courseClass.TeacherId);
            return View(courseClass);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, CourseClass courseClass)
        {
            if (id != courseClass.Id) return NotFound();
            if (ModelState.IsValid)
            {
                _context.Update(courseClass);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.CourseId = new SelectList(_context.Courses, "Id", "CourseName", courseClass.CourseId);
            ViewBag.TeacherId = new SelectList(_context.Teachers, "Id", "Name", courseClass.TeacherId);
            return View(courseClass);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var courseClass = await _context.CourseClasses
                .Include(c => c.Course)
                .Include(c => c.Teacher)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (courseClass == null) return NotFound();
            return View(courseClass);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var courseClass = await _context.CourseClasses.FindAsync(id);
            if (courseClass != null) _context.CourseClasses.Remove(courseClass);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
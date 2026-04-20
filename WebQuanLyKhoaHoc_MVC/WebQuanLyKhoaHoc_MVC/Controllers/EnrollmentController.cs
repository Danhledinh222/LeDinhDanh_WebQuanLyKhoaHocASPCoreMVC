using learnMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace learnMVC.Controllers
{
    public class EnrollmentController : Controller
    {
        private readonly AppDbContext _context;
        public EnrollmentController(AppDbContext context) => _context = context;

        public async Task<IActionResult> Index()
        {
            var enrollments = _context.Enrollments
                .Include(e => e.Student)
                .Include(e => e.CourseClass).ThenInclude(c => c.Course);
            return View(await enrollments.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) return NotFound();
            var enrollment = await _context.Enrollments
                .Include(e => e.Student)
                .Include(e => e.CourseClass).ThenInclude(c => c.Course)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (enrollment == null) return NotFound();
            return View(enrollment);
        }

        public IActionResult Create()
        {
            ViewBag.StudentId = new SelectList(_context.Students, "Id", "Name");
            ViewBag.CourseClassId = new SelectList(_context.CourseClasses.Include(c => c.Course), "Id", "Course.CourseName");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Enrollment enrollment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(enrollment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.StudentId = new SelectList(_context.Students, "Id", "Name", enrollment.StudentId);
            ViewBag.CourseClassId = new SelectList(_context.CourseClasses.Include(c => c.Course), "Id", "Course.CourseName", enrollment.CourseClassId);
            return View(enrollment);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();
            var enrollment = await _context.Enrollments.FindAsync(id);
            if (enrollment == null) return NotFound();

            ViewBag.StudentId = new SelectList(_context.Students, "Id", "Name", enrollment.StudentId);
            ViewBag.CourseClassId = new SelectList(_context.CourseClasses.Include(c => c.Course), "Id", "Course.CourseName", enrollment.CourseClassId);
            return View(enrollment);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Enrollment enrollment)
        {
            if (id != enrollment.Id) return NotFound();
            if (ModelState.IsValid)
            {
                _context.Update(enrollment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.StudentId = new SelectList(_context.Students, "Id", "Name", enrollment.StudentId);
            ViewBag.CourseClassId = new SelectList(_context.CourseClasses.Include(c => c.Course), "Id", "Course.CourseName", enrollment.CourseClassId);
            return View(enrollment);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            var enrollment = await _context.Enrollments
                .Include(e => e.Student)
                .Include(e => e.CourseClass).ThenInclude(c => c.Course)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (enrollment == null) return NotFound();
            return View(enrollment);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var enrollment = await _context.Enrollments.FindAsync(id);
            if (enrollment != null) _context.Enrollments.Remove(enrollment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
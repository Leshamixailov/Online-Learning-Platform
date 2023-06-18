using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Online_Learning_Platform.Data;
using Online_Learning_Platform.Models;

namespace Online_Learning_Platform.Controllers
{
   
    public class CoursesController : Controller
    {

        private readonly UserManager<User> _userManager;

        private readonly ApplicationDbContext _context;

        public CoursesController(ApplicationDbContext context, UserManager<User> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Courses
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Courses.Include(c => c.SubCategory).Include(c => c.User);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Courses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Courses == null)
            {
                return NotFound();
            }

            var course = await _context.Courses
                .Include(c => c.SubCategory)
                .Include(c => c.User)
                 .Include(c => c.Lessons)
                .FirstOrDefaultAsync(m => m.Id == id);
            course.Count = course.Count + 1;

            _context.Update(course);
            await _context.SaveChangesAsync();
            if (course == null)
            {
                return NotFound();
            }

            var paragraphMarker = Environment.NewLine + Environment.NewLine;
            var paragraphs = course.Description.Split(new[] { paragraphMarker },
                                            StringSplitOptions.RemoveEmptyEntries);

            ViewBag.Paragraphs = paragraphs;
            return View(course);
        }

        // GET: Courses/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {

            ViewData["SubCategoryId"] = new SelectList(_context.SubCategoreis, "Id", "Name");
            ViewBag.DataTime = DateTime.Now;
            return View();
        }

        // POST: Courses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CourseViewModel CourseViewModel)
        {
            Course course = new Course();

            var id = _userManager.FindByNameAsync(CourseViewModel.UserId).Result.Id;
            course.UserId = id;
            course.SubCategoryId = CourseViewModel.SubCategoryId;
            course.Description = CourseViewModel.Description;
            course.DateTime= CourseViewModel.DateTime; 
            course.Count = CourseViewModel.Count;

            course.Name = CourseViewModel.Name;
             
            if (CourseViewModel.Image != null)
            {
                byte[] imageData = null;
                // считываем переданный файл в массив байтов
                using (var binaryReader = new BinaryReader(CourseViewModel.Image.OpenReadStream()))
                {
                    imageData = binaryReader.ReadBytes((int)CourseViewModel.Image.Length);
                }
                // установка массива байтов
                course.Image = imageData;
            }



            _context.Add(course);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

       
        

        // GET: Courses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Courses == null)
            {
                return NotFound();
            }

            var course = await _context.Courses
                .Include(c => c.SubCategory)
                .Include(c => c.User)
                .FirstOrDefaultAsync(m => m.Id == id);

           

            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // POST: Courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Courses == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Courses'  is null.");
            }
            var course = await _context.Courses.FindAsync(id);
            if (course != null)
            {
                _context.Courses.Remove(course);
            }

            await _context.SaveChangesAsync();
            return Redirect("/Home");
        }

        private bool CourseExists(int id)
        {
            return (_context.Courses?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

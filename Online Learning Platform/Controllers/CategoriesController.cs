using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NickBuhro.Translit;
using Online_Learning_Platform.Data;
using Online_Learning_Platform.Models;

namespace Online_Learning_Platform.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }
        [Authorize(Roles = "Admin")]
        // GET: Categories
        public async Task<IActionResult> Index()
        {
            return _context.Categoreis != null ?
                        View(await _context.Categoreis.Include(s => s.SubCategory).ToListAsync()) :
                        Problem("Entity set 'ApplicationDbContext.Categoreis'  is null.");
        }

        // GET: Categories/Details/5
        public async Task<IActionResult> Details(string? nameCPU)
        {
            if (_context.Categoreis == null)
            {
                return NotFound();
            }

            var category = await _context.Categoreis.Include(s => s.SubCategory).ThenInclude(q => q.Courses)
                .FirstOrDefaultAsync(m => m.NameCPU == nameCPU);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }
        [Authorize(Roles = "Admin")]
        // GET: Categories/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([Bind("Id,Name,Controller,Action,Route")] Category category)
        {
            category.NameCPU = Transliteration.CyrillicToLatin(category.Name, Language.Russian).Replace(" ", "_");

            _context.Add(category);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
        [Authorize(Roles = "Admin")]
        // GET: Categories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Categoreis == null)
            {
                return NotFound();
            }

            var category = await _context.Categoreis.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }
        [Authorize(Roles = "Admin")]
        // POST: Categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Controller,Action,Route")] Category category)
        {
            if (id != category.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.Id))
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
            return View(category);
        }
        [Authorize(Roles = "Admin")]
        // GET: Categories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Categoreis == null)
            {
                return NotFound();
            }

            var category = await _context.Categoreis
                .FirstOrDefaultAsync(m => m.Id == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }
        [Authorize(Roles = "Admin")]
        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Categoreis == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Categoreis'  is null.");
            }
            var category = await _context.Categoreis.FindAsync(id);
            if (category != null)
            {
                _context.Categoreis.Remove(category);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CategoryExists(int id)
        {
            return (_context.Categoreis?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

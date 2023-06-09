﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Online_Learning_Platform.Data;
using Online_Learning_Platform.Models;

namespace Online_Learning_Platform.Controllers
{
    public class SubCategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SubCategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }
        [Authorize(Roles = "Admin")]
        // GET: SubCategories
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.SubCategoreis.Include(s => s.Category);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: SubCategories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.SubCategoreis == null)
            {
                return NotFound();
            }

            var subCategory = await _context.SubCategoreis
                .Include(s => s.Category).Include(q=>q.Courses)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subCategory == null)
            {
                return NotFound();
            }

            return View(subCategory);
        }
        [Authorize(Roles = "Admin")]
        // GET: SubCategories/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categoreis, "Id", "Name");
            return View();
        }
        [Authorize(Roles = "Admin")]
        // POST: SubCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,CategoryId")] SubCategory subCategory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(subCategory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categoreis, "Id", "Name", subCategory.CategoryId);
            return View(subCategory);
        }
        [Authorize(Roles = "Admin")]
        // GET: SubCategories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.SubCategoreis == null)
            {
                return NotFound();
            }

            var subCategory = await _context.SubCategoreis.FindAsync(id);
            if (subCategory == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categoreis, "Id", "Name", subCategory.CategoryId);
            return View(subCategory);
        }
        [Authorize(Roles = "Admin")]
        // POST: SubCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,CategoryId")] SubCategory subCategory)
        {
            if (id != subCategory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(subCategory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SubCategoryExists(subCategory.Id))
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
            ViewData["CategoryId"] = new SelectList(_context.Categoreis, "Id", "Name", subCategory.CategoryId);
            return View(subCategory);
        }
        [Authorize(Roles = "Admin")]
        // GET: SubCategories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.SubCategoreis == null)
            {
                return NotFound();
            }

            var subCategory = await _context.SubCategoreis
                .Include(s => s.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subCategory == null)
            {
                return NotFound();
            }

            return View(subCategory);
        }
        [Authorize(Roles = "Admin")]
        // POST: SubCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.SubCategoreis == null)
            {
                return Problem("Entity set 'ApplicationDbContext.SubCategoreis'  is null.");
            }
            var subCategory = await _context.SubCategoreis.FindAsync(id);
            if (subCategory != null)
            {
                _context.SubCategoreis.Remove(subCategory);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SubCategoryExists(int id)
        {
          return (_context.SubCategoreis?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

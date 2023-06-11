﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Learning_Platform.Data;

namespace Online_Learning_Platform.Components
{
    public class GetSubCategoriesViewComponent:ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public GetSubCategoriesViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {

            var mc = await _context.Categoreis.Include(s => s.SubCategory).ToListAsync();
            return View(mc);
        }
    }
}

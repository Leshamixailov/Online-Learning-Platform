using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Learning_Platform.Data;

namespace Online_Learning_Platform.Components
{
    public class GetCategoriesViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public GetCategoriesViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
           
            var mc = await _context.Categoreis.ToListAsync();
            return View(mc);
        }
    }
}

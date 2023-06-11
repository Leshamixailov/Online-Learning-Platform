using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Learning_Platform.Data;

namespace Online_Learning_Platform.Components
{
    public class GetCoursesViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;

        public GetCoursesViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }

       
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var Courses = await _context.Courses.Include(q=>q.User).ToListAsync();
            return View(Courses);
        }
    }
}
 
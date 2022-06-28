using Asp_Practise.DAL;
using Asp_Practise.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Practise.ViewComponents
{
    public class CourseViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;

        public CourseViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int take)
        {
            List<Course> courses = _context.Courses.Take(take).ToList();

            return View(await Task.FromResult(courses));
        }
    }
}

using Asp_Practise.DAL;
using Asp_Practise.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Asp_Practise.Controllers
{
    public class CourseController:Controller
    {
        private readonly AppDbContext _context;

        public CourseController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            CourseVM courseVM= new CourseVM();
            courseVM.Courses = _context.Courses.ToList();
            return View(courseVM);

        }
    }
}

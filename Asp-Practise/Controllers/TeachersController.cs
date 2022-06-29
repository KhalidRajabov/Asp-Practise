using Asp_Practise.DAL;
using Asp_Practise.Models;
using Asp_Practise.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Asp_Practise.Controllers
{
    public class TeachersController : Controller
    {
        private readonly AppDbContext _context;

        public TeachersController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            TeacherVM teacherVM = new TeacherVM();
            teacherVM.Teachers = _context.Teachers.ToList();

            return View(teacherVM);
        }

        public IActionResult SearchTeachers(string search)
        {
            List<Teacher> courses = _context.Teachers
                .OrderBy(p => p.Id).Where(p => p.Name.ToLower().Contains(search.ToLower())|| p.Category.ToLower().Contains(search.ToLower()))
                .ToList();

            return PartialView("_TeacherSearchPartial", courses);
        }

        public IActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Teacher dbTeacher = _context.Teachers.FirstOrDefault(p => p.Id == id);
            if (dbTeacher == null) return NotFound();

            return View(dbTeacher);
        }
    }
}

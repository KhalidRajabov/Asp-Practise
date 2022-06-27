using Asp_Practise.DAL;
using Asp_Practise.Models;
using Asp_Practise.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Practise.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM homevm = new HomeVM();

            homevm.Slider=_context.Slider.ToList();
            homevm.NoticeBoards=_context.NoticeBoards.ToList();
            homevm.NoticeSubjects= _context.NoticeSubjects.ToList();
            homevm.Banners=_context.Banners.FirstOrDefault();
            homevm.Quote = _context.Quote.FirstOrDefault();
            homevm.Courses= _context.Courses.Take(3).ToList();
            homevm.Events=_context.Events.Take(4).ToList();
            return View(homevm);
        }
        public IActionResult SearchCourse(string search)
        {
            List<Course> courses = _context.Courses
                .OrderBy(p => p.Id).Where(p => p.Name.ToLower().Contains(search.ToLower())|| p.Details.ToLower().Contains(search.ToLower()))

                .ToList();

            return PartialView("_HomeSearchPartial",courses);
        }
    }
}
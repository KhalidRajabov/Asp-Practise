using Asp_Practise.DAL;
using Asp_Practise.Models;
using Asp_Practise.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Asp_Practise.Controllers
{
    public class BlogController:Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            BlogVM homevm = new BlogVM();
            homevm.Blogs = _context.Blogs.ToList();
            return View(homevm);
        }

        public IActionResult SearchBlogs(string search)
        {
            List<Blog> courses = _context.Blogs
                .OrderBy(p => p.Id).Where(p => p.Title.ToLower().Contains(search.ToLower()))
                .ToList();

            return PartialView("_BlogSearchPartial", courses);
        }

        public IActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Blog dbBlog = _context.Blogs.FirstOrDefault(p => p.Id == id);
            if (dbBlog == null) return NotFound();

            return View(dbBlog);
        }
    }
}
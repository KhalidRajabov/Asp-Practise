using Asp_Practise.DAL;
using Asp_Practise.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Practise.ViewComponents
{
    public class TeacherViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;

        public TeacherViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Teacher> teachers = _context.Teachers.ToList();

            return View(await Task.FromResult(teachers));
        }
    }
}

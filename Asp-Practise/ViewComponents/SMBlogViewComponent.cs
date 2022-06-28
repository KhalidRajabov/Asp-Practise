using Asp_Practise.DAL;
using Asp_Practise.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Practise.ViewComponents
{
    public class SMBlogViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;

        public SMBlogViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int take)
        {
            List<Blog> smblogs= _context.Blogs.Take(take).ToList();

            return View(await Task.FromResult(smblogs));

        }
    }
}

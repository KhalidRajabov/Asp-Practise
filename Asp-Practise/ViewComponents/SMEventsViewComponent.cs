using Asp_Practise.DAL;
using Asp_Practise.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Practise.ViewComponents
{
    public class SMEventsViewComponent:ViewComponent
    {
        private readonly AppDbContext _context;

        public SMEventsViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(int skip)
        {
            List<Event> teachers = _context.Events.Skip(skip).Take(4).ToList();

            return View(await Task.FromResult(teachers));
        }
    }
}

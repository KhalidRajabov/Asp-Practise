using Asp_Practise.DAL;
using Asp_Practise.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Practise.ViewComponents
{
    public class EventViewComponent: ViewComponent
    {
        private readonly AppDbContext _context;

        public EventViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Event> events = _context.Events.ToList();

            return View(await Task.FromResult(events));
        }
    }
}

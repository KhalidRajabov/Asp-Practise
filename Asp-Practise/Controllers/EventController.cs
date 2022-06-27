using Asp_Practise.DAL;
using Asp_Practise.Models;
using Asp_Practise.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Asp_Practise.Controllers
{
    public class EventController : Controller
    {
        private readonly AppDbContext _context;

        public EventController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            EventVM eventVM = new EventVM();
            eventVM.Events= _context.Events.ToList();
            return View(eventVM);
        }

        public IActionResult Details(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Event dbEvent = _context.Events.Include(t=>t.EventTeachers).ThenInclude(p=>p.Teacher)
                .FirstOrDefault(p => p.Id == id);
            if (dbEvent == null) return NotFound();
            
            return View(dbEvent);
        }
    }
}

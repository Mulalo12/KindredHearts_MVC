using Microsoft.AspNetCore.Mvc;
using Testing.Models;
using YourProjectName.Models;

namespace Testing.Controllers
{
    public class VolunteerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VolunteerController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Volunteer volunteer)
        {
            if (ModelState.IsValid)
            {
                _context.Volunteers.Add(volunteer);
                await _context.SaveChangesAsync();
                return RedirectToAction("ThankYou");
            }
            return View(volunteer);
        }

        public IActionResult ThankYou()
        {
            return View();
        }
    }
}

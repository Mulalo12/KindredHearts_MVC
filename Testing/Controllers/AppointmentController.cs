using Microsoft.AspNetCore.Mvc;
using Testing.Models;

namespace Testing.Controllers
{
    public class AppointmentController : Controller
    {
        private readonly ApplicationDbContext _context;

        // Inject the ApplicationDbContext to perform database operations
        public AppointmentController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Appointment appointment)
        {
            if (ModelState.IsValid)
            {
                // Add the new appointment to the database
                _context.Appointments.Add(appointment);
                await _context.SaveChangesAsync();
                return RedirectToAction("ThankYou");
            }
            return View(appointment);
        }

        public IActionResult ThankYou()
        {
            return View();
        }
    }
}

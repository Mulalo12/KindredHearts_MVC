using Microsoft.AspNetCore.Mvc;
using Testing.Models;

namespace Testing.Controllers
{
    public class JoinController : Controller
    {
        private readonly ApplicationDbContext _context;

        public JoinController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View("~/Views/Join/Index.cshtml");
        }

        [HttpPost]
        public async Task<IActionResult> Index(Models.Join join) 
        {
            if (ModelState.IsValid)
            {
                _context.JoinRecords.Add(join);
                await _context.SaveChangesAsync();
                return RedirectToAction("ThankYou");
            }
            return View("~/Views/Join/Index.cshtml", join);
        }

        public IActionResult ThankYou()
        {
            return View("~/Views/Join/ThankYou.cshtml");
        }
    }
}

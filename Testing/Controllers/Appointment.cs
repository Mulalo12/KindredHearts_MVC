using Microsoft.AspNetCore.Mvc;

namespace Testing.Controllers
{
    public class Appointment : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

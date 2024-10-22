using Microsoft.AspNetCore.Mvc;

namespace Testing.Controllers
{
    public class Login : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

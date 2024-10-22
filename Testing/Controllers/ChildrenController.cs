using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

public class ChildrenController : Controller
{
    private readonly ApplicationDbContext _context;

    public ChildrenController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        var children = _context.Children.ToList(); // Fetch children from the database
        return View(children);
    }
    public async Task<IActionResult> Details(int id)
    {
        var child = await _context.Children.FindAsync(id);
        if (child == null)
        {
            return NotFound();
        }
        return View(child); // This returns the details view with the child's details
    }

}

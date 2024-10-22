using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Testing.Controllers;
using Testing.Models;
using YourProjectName.Models;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Volunteer> Volunteers { get; set; }
    public DbSet<Child> Children { get; set; }
    
    // Add this line
}
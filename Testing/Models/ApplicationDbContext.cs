using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Testing.Controllers;
using Testing.Models;

public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
       public DbSet<Join> JoinRecords { get; set; }
    public DbSet<Child> Children { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
}
    
    
    // Add this line
}

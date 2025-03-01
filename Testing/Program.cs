using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();


// Add MVC support
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "register",
    pattern: "Account/Register",
    defaults: new { controller = "Account", action = "Register" });

app.MapControllerRoute(
    name: "login",
    pattern: "Account/Login",
    defaults: new { controller = "Account", action = "Login" });
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Children}/{action=Index}/{id?}"); // Set to the Children controller

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Volunteer}/{action=Create}/{id?}");


app.MapControllerRoute(
    name: "Join",
    pattern: "{controller=Join}/{action=Index}/{id?}");  // Join controller

app.MapControllerRoute(
    name: "appointment",
    pattern: "{controller=Appointment}/{action=Create}/{id?}");  // Appointment controller


app.Run();


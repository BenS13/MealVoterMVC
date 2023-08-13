using Microsoft.EntityFrameworkCore;
using MealVoterMVC.Data;
using MealVoterMVC.Services;
using MealVoterMVC.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MealContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ContentContext") ?? throw new InvalidOperationException("Connection string 'ContentContext' not found.")));

//Register the MealService so it can be injected into any page
builder.Services.AddScoped<MealService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

using GeekShopping.IdentityServer.Model.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

var connection = builder.Configuration.GetConnectionString("MySQLConnection");

builder.Services.AddDbContext<MySQLContext>(options =>
    options.UseMySql(connection, new MySqlServerVersion(new Version(8, 0, 29))));

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

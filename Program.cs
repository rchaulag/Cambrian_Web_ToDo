using Microsoft.EntityFrameworkCore;
using Assignment_ToDoWebApp.ToDoWeb.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.using DI
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ToDoContext>(options =>{
    options.UseSqlite(@"Data Source=c:\Temp\\mydb.db;");
   // options.UseMySql(@"Connection String ="); // uses my sql db 
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

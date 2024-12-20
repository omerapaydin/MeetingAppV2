using MeetingApp.Data.Abstract;
using MeetingApp.Data.Concrate.EfCore;
using MeetingApp.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();



builder.Services.AddDbContext<BlogContext>(options =>
{
    options.UseSqlite(builder.Configuration["ConnectionStrings:sql_connection"]);
});


builder.Services.AddScoped<IMeetRepository,EfMeetRepository>();
builder.Services.AddScoped<IUserRepository,EfUserRepository>();



var app = builder.Build();


app.UseRouting();
app.UseHttpsRedirection();
app.UseStaticFiles();



app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

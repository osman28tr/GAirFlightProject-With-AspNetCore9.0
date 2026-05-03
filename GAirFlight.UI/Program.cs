using GAirFlight.UI.Contexts;
using GAirFlight.UI.Repositories;
using GAirFlight.UI.Repositories.Abstract;
using GAirFlight.UI.Services.Flight;
using GAirFlight.UI.Services.Flight.Abstract;
using GAirFlight.UI.Settings;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//implement the option design pattern for the database connection string
builder.Services.Configure<DatabaseSetting>(
	builder.Configuration.GetSection("ConnectionStrings"));
builder.Services.AddScoped<IFlightRepository, FlightRepository>();
builder.Services.AddScoped<IFlightService, FlightService>();

builder.Services.AddDbContext<GAirDbContext>(options =>
{
	options.UseNpgsql(builder.Configuration.GetConnectionString("DatabaseSetting"));
});

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
	pattern: "{controller=Default}/{action=Index}/{id?}");

app.UseEndpoints(endpoints =>
{
	endpoints?.MapControllerRoute(
	  name: "areas",
	  pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
	);
});

app.Run();

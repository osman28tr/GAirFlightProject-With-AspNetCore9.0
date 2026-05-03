using GAirFlight.UI.Entities;
using Microsoft.EntityFrameworkCore;

namespace GAirFlight.UI.Contexts
{
	public class GAirDbContext(DbContextOptions options) : DbContext(options)
	{
		public DbSet<Flight> Flights { get; set; }
		public DbSet<Airline> Airlines { get; set; }
		public DbSet<Airport> Airports { get; set; }
	}
}

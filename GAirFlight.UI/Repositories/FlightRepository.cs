using GAirFlight.UI.Contexts;
using GAirFlight.UI.Entities;
using GAirFlight.UI.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;

namespace GAirFlight.UI.Repositories
{
	public class FlightRepository : IFlightRepository
	{
		private readonly GAirDbContext _context;

		public FlightRepository(GAirDbContext context)
		{
			_context = context;
		}

		public async Task CreateAsync(Flight entity)
		{
			_context.Flights.Add(entity);
			await _context.SaveChangesAsync();
		}

		public async Task DeleteAsync(int id)
		{
			var flight = await _context.Flights.FindAsync(id);
			if (flight != null)
			{
				_context.Flights.Remove(flight);
				await _context.SaveChangesAsync();
			}
			else
			{
				throw new KeyNotFoundException($"Flight with ID {id} not found.");
			}
		}

		public async Task<List<Flight>> GetAllAsync()
		{
			var flights = await _context.Flights
				.Include(f => f.Airline)
				.Include(f => f.DepartureAirport)
				.Include(f => f.ArrivalAirport)
				.ToListAsync();
			return flights;
		}

		public async Task<Flight> GetAsync(int id)
		{
			var flight = await _context.Flights
				.Include(f => f.Airline)
				.Include(f => f.DepartureAirport)
				.Include(f => f.ArrivalAirport)
				.FirstOrDefaultAsync(f => f.FlightId == id);
			if (flight == null)
			{
				throw new KeyNotFoundException($"Flight with ID {id} not found.");
			}
			return flight;
		}

		public async Task UpdateAsync(Flight entity)
		{
			_context.Flights.Update(entity);
			await _context.SaveChangesAsync();
		}
	}
}

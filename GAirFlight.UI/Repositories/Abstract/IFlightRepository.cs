using GAirFlight.UI.Entities;

namespace GAirFlight.UI.Repositories.Abstract
{
	public interface IFlightRepository
	{
		Task<List<Flight>> GetAllAsync();
		Task<Flight> GetAsync(int id);
		Task UpdateAsync(Flight entity);
		Task DeleteAsync(int id);
		Task CreateAsync(Flight entity);
	}
}

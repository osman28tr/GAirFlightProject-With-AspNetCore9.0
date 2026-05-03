using GAirFlight.UI.Services.Flight.Dtos;

namespace GAirFlight.UI.Services.Flight.Abstract
{
	public interface IFlightService
	{
		Task<List<GetListFlightDto>> GetAllAsync();
		Task<GetByIdFlightDto> GetByIdAsync(int id);
		Task UpdateAsync(UpdateFlightDto updateFlightDto);
		Task DeleteAsync(int id);
		Task CreateAsync(CreateFlightDto createFlightDto);
	}
}

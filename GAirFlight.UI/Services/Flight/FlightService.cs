using AutoMapper;
using GAirFlight.UI.Repositories.Abstract;
using GAirFlight.UI.Services.Flight.Abstract;
using GAirFlight.UI.Services.Flight.Dtos;

namespace GAirFlight.UI.Services.Flight
{
	public class FlightService : IFlightService
	{
		private readonly IFlightRepository _flightRepository;
		private readonly IMapper _mapper;

		public FlightService(IFlightRepository flightRepository, IMapper mapper)
		{
			_flightRepository = flightRepository;
			_mapper = mapper;
		}

		public async Task CreateAsync(CreateFlightDto createFlightDto)
		{
			var flightEntity = _mapper.Map<Entities.Flight>(createFlightDto);
			await _flightRepository.CreateAsync(flightEntity);
		}

		public async Task DeleteAsync(int id)
		{
			await _flightRepository.DeleteAsync(id);
		}

		public async Task<List<GetListFlightDto>> GetAllAsync()
		{
			var flightEntities = await _flightRepository.GetAllAsync();
			return _mapper.Map<List<GetListFlightDto>>(flightEntities);
		}

		public async Task<GetByIdFlightDto> GetByIdAsync(int id)
		{
			var flightEntity = await _flightRepository.GetAsync(id);
			return _mapper.Map<GetByIdFlightDto>(flightEntity);
		}

		public async Task UpdateAsync(UpdateFlightDto updateFlightDto)
		{
			var flightEntity = _mapper.Map<Entities.Flight>(updateFlightDto);
			await _flightRepository.UpdateAsync(flightEntity);
		}
	}
}

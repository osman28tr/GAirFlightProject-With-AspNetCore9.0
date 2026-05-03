using AutoMapper;
using GAirFlight.UI.Entities;
using GAirFlight.UI.Services.Flight.Dtos;

namespace GAirFlight.UI.Services.Flight.Profiles
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			CreateMap<Entities.Flight, CreateFlightDto>()				
				.ReverseMap();
			CreateMap<Entities.Flight, GetListFlightDto>()
				.ForMember(dest => dest.AirlineDto, opt => opt.MapFrom(x => x.Airline))
				.ForMember(dest => dest.DepartureAirportDto, opt => opt.MapFrom(x => x.DepartureAirport))
				.ForMember(dest => dest.ArrivalAirportDto, opt => opt.MapFrom(x => x.ArrivalAirport))
				.ReverseMap();
			CreateMap<Entities.Flight,GetByIdFlightDto>()
				.ForMember(dest => dest.AirlineDto, opt => opt.MapFrom(x => x.Airline))
				.ForMember(dest => dest.DepartureAirportDto, opt => opt.MapFrom(x => x.DepartureAirport))
				.ForMember(dest => dest.ArrivalAirportDto, opt => opt.MapFrom(x => x.ArrivalAirport))
				.ReverseMap();
			CreateMap<Entities.Flight,UpdateFlightDto>() .ReverseMap();
		}
	}
}

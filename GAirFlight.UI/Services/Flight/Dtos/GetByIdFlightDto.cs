namespace GAirFlight.UI.Services.Flight.Dtos
{
	public class GetByIdFlightDto
	{
		public GetByIdFlightDto()
		{
			AirlineDto= new AirlineDto();
			DepartureAirportDto= new AirportDto();
			ArrivalAirportDto = new AirportDto();
		}
		public int AirlineId { get; set; }
		public int DepartureAirportId { get; set; }
		public int ArrivalAirportId { get; set; }
		public string FlightNumber { get; set; }
		public AirlineDto AirlineDto { get; set; }
		public AirportDto DepartureAirportDto { get; set; }
		public AirportDto ArrivalAirportDto { get; set; }
		public DateTime DepartureTime { get; set; }
		public DateTime ArrivalTime { get; set; }
		public int DurationMinutes { get; set; }
		public int TotalSeats { get; set; }
		public int AvailableSeats { get; set; }
		public decimal BasePrice { get; set; }
		public string Currency { get; set; }
		public string Status { get; set; }
	}
	public class AirlineDto
	{
		public int AirlineId { get; set; }
		public string Name { get; set; }
		public string Code { get; set; }
	}
	public class AirportDto
	{
		public int AirportId { get; set; }
		public string Name { get; set; }
		public string Code { get; set; }
		public string City { get; set; }
		public string Country { get; set; }
	}
}

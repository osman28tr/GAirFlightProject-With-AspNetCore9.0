namespace GAirFlight.UI.Services.Flight.Dtos
{
	public class UpdateFlightDto
	{
		public int AirlineId { get; set; }
		public int DepartureAirportId { get; set; }
		public int ArrivalAirportId { get; set; }
		public string FlightNumber { get; set; }
		public DateTime DepartureTime { get; set; }
		public DateTime ArrivalTime { get; set; }
		public int DurationMinutes { get; set; }
		public int TotalSeats { get; set; }
		public int AvailableSeats { get; set; }
		public decimal BasePrice { get; set; }
		public string Currency { get; set; }
		public string Status { get; set; }
	}
}

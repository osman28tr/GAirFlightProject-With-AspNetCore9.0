namespace GAirFlight.UI.Entities
{
	public class Flight
	{
		public int FlightId { get; set; }
		public int AirlineId { get; set; }
		public int DepartureAirportId { get; set; }
		public int ArrivalAirportId { get; set; }
		public string FlightNumber { get; set; }
		public Airline Airline { get; set; }		
		public Airport DepartureAirport { get; set; }		
		public Airport ArrivalAirport { get; set; }
		public DateTime DepartureTime { get; set; }
		public DateTime ArrivalTime { get; set; }
		public int DurationMinutes { get; set; }
		public int TotalSeats { get; set; }
		public int AvailableSeats { get; set; }
		public decimal BasePrice { get; set; }
		public string Currency { get; set; }
		public string Status { get; set; } 

	}
	public enum FlightStatus
	{
		Scheduled = 0,
		Delayed = 1,
		Cancelled = 2,
		Completed = 3
	}
}

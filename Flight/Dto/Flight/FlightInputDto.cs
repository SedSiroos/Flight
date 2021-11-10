using System;

namespace Flight.Dto.Flight
{
    public class FlightInputDto
    {
        public string SourceName { get; set; }
        public string DestinationName { get; set; }
        public string FlightDate { get; set; }
        public  string SortyBy { get; set; }
    }

    public class FlightOutputDto
    {
        public int FlightId { get; set; }
        public string SourceName { get; set; }
        public string DestinationName { get; set; }
        public string FlightDate { get; set; }
        public decimal Price { get; set; }
        public int RemainingSeats { get; set; }
    }
}

using System;
using Flight.Entity.Domain;

namespace Flight.Dto.Flight
{
    public class CreateFlight
    {
        public int CompanyAirlineId { get; set; }
        public int SourceId { get; set; }
        public int DestinationId { get; set; }
        public DateTime FlightDate { get; set; }
        public decimal Price { get; set; }
        public int SeatsCount { get; set; }
        public int AirPlaneNameId { get; set; }
        public FlightType FlightType { get; set; }
        public RateClass RateClass { get; set; }
    }
}

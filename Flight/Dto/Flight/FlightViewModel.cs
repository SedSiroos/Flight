using Flight.Entity.Domain;

namespace Flight.Dto.Flight
{
    public class FlightViewModel 
    {
        public int Id { get; set; }
        public int CompanyAirLine { get; set; }
        public string FlightDate { get; set; }
        public FlightType FlightType { get; set; }
        public RateClass Class { get; set; }
        public int SeatsCount { get; set; }
    }
}
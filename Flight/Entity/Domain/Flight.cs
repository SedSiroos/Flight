using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Flight.Entity.Domain
{
    public class Flight
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(AirLine))]
        public int CompanyAirlineId { get;  set; }
        public AirLine AirLine { get; set; }

        [ForeignKey(nameof(Source))]
        public int SourceId { get;  set; }
        public City Source { get; set; }


        [ForeignKey(nameof(Destination))]
        public int DestinationId { get;  set; }
        public City Destination { get; set; }

        public int SeatsCount { get; set; } 
        public DateTime FlightDate { get;  set; }
        public decimal Price { get;  set; }


        [ForeignKey(nameof(AirPlan))]
        public int AirPlaneNameId { get;  set; }
        public Airplane AirPlan { get; set; }

        public FlightType FlightType { get; set; }
        public RateClass RateClass { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<Inventory> Inventories { get; set; }

        public Flight()
        {
            FlightDate = DateTime.Now;
        }
    }

    public enum FlightType
    {
        Systemic = 1,
        Charter = 2
    }
    public enum RateClass
    {
        Economy = 1,
        Business = 2,
        FirstClass = 3
    }
}


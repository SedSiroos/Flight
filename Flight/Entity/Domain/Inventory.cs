using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Flight.Entity.Domain
{
    public class Inventory
    {
        public int Id { get; set; }
        [ForeignKey(nameof(Flight))]
        public int FlightId { get; set; }
        public Flight Flight { get; set; }
        public int OrderId { get; set; }
        public bool InStock { get; set; }
        public int CurrentCount { get; set; }
    }
}

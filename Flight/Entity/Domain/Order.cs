using System.ComponentModel.DataAnnotations.Schema;

namespace Flight.Entity.Domain
{
    public class Order
    {
        public int Id { get; set; }
        [ForeignKey(nameof(Account))]
        public int UserId { get; set; }
        [ForeignKey(nameof(Flight))]
        public int FlightId { get; set; }
        public Account Account { get; set; }
        public Flight Flight { get; set; }
    }
}

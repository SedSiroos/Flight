namespace Flight.Dto.Inventory
{
    public class CreateInventory
    {
        public int FlightId { get; set; }
        public int OrderId { get; set; }
        public bool InStock { get; set; }
        public bool Operation { get; set; }
        public int SeatsCount { get; set; }
    }
}

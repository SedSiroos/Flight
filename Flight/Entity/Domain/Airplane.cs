using System;
using System.ComponentModel.DataAnnotations;

namespace Flight.Entity.Domain
{
    public class Airplane
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}

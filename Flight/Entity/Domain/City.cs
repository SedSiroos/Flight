using System;
using System.ComponentModel.DataAnnotations;

namespace Flight.Entity.Domain
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Name { get; set; }


    }
}

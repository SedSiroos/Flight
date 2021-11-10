using System;
using System.ComponentModel.DataAnnotations;

namespace Flight.Entity.Domain
{
    public class AirLine
    {
        [Key]
        public int Id { get; set; }
        public string Name { get;  set; }
        public string Logo { get;  set; }

        public DateTime CreatedDate { get; set; }

        public void Edit( string companyName, string logo)
        {
            Name = companyName;
            Logo = logo;
        }
    }
}

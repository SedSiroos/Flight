using System.Collections.Generic;

namespace Flight.Entity.Domain
{
    public class Account
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Account(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }   
        public void Edit (string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}

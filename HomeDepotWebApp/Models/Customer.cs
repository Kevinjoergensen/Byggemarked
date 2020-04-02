using System;

namespace HomeDepotWebApp.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
    }
}
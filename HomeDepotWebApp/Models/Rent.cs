using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeDepotWebApp.Models
{
    public class Rent
    {
        public int Id { get; set; }
        public Tool Tool { get; set; }
        public Costumer Costumer { get; set; }
        public String Pickuptime { get; set; }
        public int Days { get; set; }
        private Status Status { get; set; }
    }

    enum Status
    {
        Reserveret,
        Udleveret,
        Tilbageleveret
    }
}
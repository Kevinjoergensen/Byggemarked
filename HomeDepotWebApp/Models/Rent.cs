using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeDepotWebApp.Models {
    public class Rent {

        public int Id { get; set; }
        public int ToolId { get; set; }
        public int CustomerID { get; set; }
        public Tool tool { get; set; }
        public Customer Customer { get; set; }
        public String PickUp { get; set; }
        public int Days { get; set; }
        public Boolean Status { get; set; }
    }
}
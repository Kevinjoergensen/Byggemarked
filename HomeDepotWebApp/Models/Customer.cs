using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HomeDepotWebApp.Models {
    public class Customer {
        [Key]
        public int Id { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
    }
}
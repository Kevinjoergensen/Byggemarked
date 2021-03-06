﻿using System;

namespace HomeDepotWebApp.Models
{
    public class Rent
    {

        public int Id { get; set; }
        public virtual Tool RentTool { get; set; }
        public virtual Customer Customer { get; set; }
        public String PickUp { get; set; }
        public int Days { get; set; }
        public Status Status { get; set; }
    }

    public enum Status
    {
        Reserveret,
        Udleveret,
        Tilbageleveret
    }
}
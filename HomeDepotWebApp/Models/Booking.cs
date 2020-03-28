namespace HomeDepotWebApp.Models
{
    public class Booking
    {
        public Costumer costumer { get; set; }
        public Tool tool { get; set; }
        public DateTime booked { get; set; }
        public double totalTime { get; set; }
        
    }
}
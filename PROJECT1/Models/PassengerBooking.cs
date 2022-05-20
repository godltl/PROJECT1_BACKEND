using System.ComponentModel.DataAnnotations;

namespace PROJECT1.Models
{
    public class PassengerBooking
    {
        [Key]
        public int FlightNumber { get; set; }
        public string BookingNumber { get; set; } = string.Empty;
    }
}

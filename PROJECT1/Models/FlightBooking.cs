using System.ComponentModel.DataAnnotations;
namespace PROJECT1.Models
{
    public class FlightBooking
    {
        public int Id { get; set; }
        public string BookingNumber { get; set; } = string.Empty;
    }
}

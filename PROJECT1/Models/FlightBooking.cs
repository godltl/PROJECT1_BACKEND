using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROJECT1.Models
{
    [Index(nameof(PassengerId),nameof(FlightNumber), IsUnique = true)]
    public class FlightBooking
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BookingNumber { get; set; }
        public int PassengerId { get; set; } 
        public Passenger? Passenger { get; set; }
        public int FlightNumber { get; set; }
        public Flight? Flight { get; set; }

    }
}

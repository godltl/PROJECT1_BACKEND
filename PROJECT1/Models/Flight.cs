using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROJECT1.Models
{
    [Index(nameof(DepartureDate), nameof(ArrivalDate), nameof(DepartureTime), nameof(ArrivalTime), nameof(DepartureAirport), nameof(ArrivalAirport), nameof(PassengerLimit), IsUnique = true)]
    public class Flight
    {


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FlightNumber { get; set; } 
        public string DepartureDate { get; set; } = string.Empty;
        public string ArrivalDate { get; set; } = string.Empty;
        public string DepartureTime { get; set; } = string.Empty;
        public string ArrivalTime { get; set; } = string.Empty;
        [MaxLength(3)]
        public string DepartureAirport { get; set; } = string.Empty;
        [MaxLength(3)]
        public string ArrivalAirport { get; set; } = string.Empty;
      
        public byte PassengerLimit { get; set; }

        public List<FlightBooking>? FlightBookings { get; set; }






    }
}

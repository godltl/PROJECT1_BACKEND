using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROJECT1.Models
{
    public class Flight
    {


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int FlightNumber { get; set; } 
        public string DepartureDate { get; set; } = string.Empty;
        public string ArrivalDate { get; set; } = string.Empty;
        public string DepartureTime { get; set; } = string.Empty;
        public string ArrivalTime { get; set; } = string.Empty;
        public string DepartureAirport { get; set; } = string.Empty;
        public string ArrivalAirport { get; set; } = string.Empty;
        public int PassengerLimit { get; set; }

        




    }
}

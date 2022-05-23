using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROJECT1.Models
{
    [Index(nameof(Email),IsUnique=true)]
    public class Passenger
    {

        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PassengerId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(50)]
        public string Job { get; set; } = string.Empty;
        
        public string Email { get; set; } = string.Empty;

        public byte Age { get; set; }
        public List<FlightBooking>? FlightBookings { get; set; }

       

    }
}

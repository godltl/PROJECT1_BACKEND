using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROJECT1.Models
{
    public class Passenger
    {
        

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string PassengerId { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Job { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int Age { get; set; }
        public int ConfirmationNumber { get; set; }

       

    }
}

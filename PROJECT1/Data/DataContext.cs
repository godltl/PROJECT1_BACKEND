using Microsoft.EntityFrameworkCore;
using PROJECT1.Models;

namespace PROJECT1.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Passenger> Passengers { get; set; }

        public DbSet<Flight> Flights { get; set; }

        public DbSet<FlightBooking> FlightBookings { get; set; }

        public DbSet<PassengerBooking> PassengerBookings { get; set; }




    }
}

using Microsoft.EntityFrameworkCore;
using PROJECT1.Models;

namespace PROJECT1.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FlightBooking>()
                .HasOne(p => p.Passenger)
                .WithMany(fb => fb.FlightBookings)
                .HasForeignKey(pi => pi.PassengerId);

            modelBuilder.Entity<FlightBooking>()
                .HasOne(f => f.Flight)
                .WithMany(fb => fb.FlightBookings)
                .HasForeignKey(fn => fn.FlightNumber);
        }

        public DbSet<Passenger> Passengers { get; set; }

        public DbSet<Flight> Flights { get; set; }

        public DbSet<FlightBooking> FlightBookings { get; set; }

     




    }
}

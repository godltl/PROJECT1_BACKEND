using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PROJECT1.Models;

namespace PROJECT1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightBookingController : ControllerBase
    {
        public static List<FlightBooking> FlightBookings = new List<FlightBooking>
        {
        };
        private readonly DataContext context;

        public FlightBookingController(DataContext Context)
        {
            context = Context;
        }

        [HttpGet]
        public async Task<ActionResult<List<FlightBooking>>> Get()
        {
            return Ok(await context.FlightBookings.ToListAsync());
        }

        [HttpGet("{Id}")]
        public async Task<ActionResult<FlightBooking>> Get(int Id)
        {
            var FlightBooking = await context.Flights.FindAsync(Id);
            if (FlightBooking == null)
            {
                return BadRequest("No such Flight Booking exists");
            }
            return Ok(FlightBooking);
        }

        [HttpPost]
        public async Task<ActionResult<List<FlightBooking>>> AddFlightBooking(FlightBooking FlightBooking)
        {
            context.FlightBookings.Add(FlightBooking);
            await context.SaveChangesAsync();
            return Ok(await context.FlightBookings.ToListAsync());
        }

        [HttpPut]

        public async Task<ActionResult<List<FlightBooking>>> UpdateFlightBooking(FlightBooking request)
        {
            var dbFlightBooking = await context.FlightBookings.FindAsync(request.Id);
            if (dbFlightBooking == null)
            {
                return BadRequest("No such Flight Booking exists");
            }


            dbFlightBooking.Id = request.Id;
            dbFlightBooking.BookingNumber = request.BookingNumber;

            await context.SaveChangesAsync();

            return Ok(await context.FlightBookings.ToListAsync());
        }

        [HttpDelete("{Id}")]
        public async Task<ActionResult<List<FlightBooking>>> Delete(int Id)
        {
            var FlightBooking = FlightBookings.Find(h => h.Id == Id);
            if (FlightBooking == null)
            {
                return BadRequest("No such Flight Booking exists");
            }
            FlightBookings.Remove(FlightBooking);
            return Ok(FlightBookings);
        }
    }
}

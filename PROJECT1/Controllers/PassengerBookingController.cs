using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PROJECT1.Models;

namespace PROJECT1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengerBookingController : ControllerBase
    {
        public static List<PassengerBooking> PassengerBookings = new List<PassengerBooking>
        {
        };
        private readonly DataContext context;

        public PassengerBookingController(DataContext Context)
        {
            context = Context;
        }

        [HttpGet]
        public async Task<ActionResult<List<PassengerBooking>>> Get()
        {
            return Ok(await context.PassengerBookings.ToListAsync());
        }

        [HttpGet("{FlightNumber}")]
        public async Task<ActionResult<PassengerBooking>> Get(int FlightNumber)
        {
            var PassengerBooking = await context.PassengerBookings.FindAsync(FlightNumber);
            if (PassengerBooking == null)
            {
                return BadRequest("No such Passenger Booking exists");
            }
            return Ok(PassengerBooking);
        }

        [HttpPost]
        public async Task<ActionResult<List<PassengerBooking>>> AddPassengerBooking(PassengerBooking PassengerBooking)
        {
            context.PassengerBookings.Add(PassengerBooking);
            await context.SaveChangesAsync();
            return Ok(await context.PassengerBookings.ToListAsync());
        }

        [HttpPut]

        public async Task<ActionResult<List<PassengerBooking>>> UpdatePassengerBooking(PassengerBooking request)
        {
            var dbPassengerBooking = await context.PassengerBookings.FindAsync(request.FlightNumber);
            if (dbPassengerBooking == null)
            {
                return BadRequest("No such Passenger Booking exists");
            }


            dbPassengerBooking.FlightNumber = request.FlightNumber;
            dbPassengerBooking.BookingNumber = request.BookingNumber;

            await context.SaveChangesAsync();

            return Ok(await context.PassengerBookings.ToListAsync());
        }

        [HttpDelete("{FlightNumber}")]
        public async Task<ActionResult<List<PassengerBooking>>> Delete(int FlightNumber)
        {
            var PassengerBooking = PassengerBookings.Find(h => h.FlightNumber == FlightNumber);
            if (PassengerBooking == null)
            {
                return BadRequest("No such Passenger Booking exists");
            }
            PassengerBookings.Remove(PassengerBooking);
            return Ok(PassengerBooking);
        }
    }
}

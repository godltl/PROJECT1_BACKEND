using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROJECT1.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FlightBookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightBookings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    FlightNumber = table.Column<int>(type: "int", nullable: false),
                    DepartureDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArrivalDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartureTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArrivalTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartureAirport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArrivalAirport = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassengerLimit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.FlightNumber);
                });

            migrationBuilder.CreateTable(
                name: "PassengerBookings",
                columns: table => new
                {
                    FlightNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingNumber = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassengerBookings", x => x.FlightNumber);
                });

            migrationBuilder.CreateTable(
                name: "Passengers",
                columns: table => new
                {
                    PassengerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Job = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    ConfirmationNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passengers", x => x.PassengerId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlightBookings");

            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "PassengerBookings");

            migrationBuilder.DropTable(
                name: "Passengers");
        }
    }
}

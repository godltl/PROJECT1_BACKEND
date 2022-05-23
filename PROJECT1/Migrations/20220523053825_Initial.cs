using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PROJECT1.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    FlightNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartureDate = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ArrivalDate = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DepartureTime = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ArrivalTime = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DepartureAirport = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    ArrivalAirport = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    PassengerLimit = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.FlightNumber);
                });

            migrationBuilder.CreateTable(
                name: "Passengers",
                columns: table => new
                {
                    PassengerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Job = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Age = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passengers", x => x.PassengerId);
                });

            migrationBuilder.CreateTable(
                name: "FlightBookings",
                columns: table => new
                {
                    BookingNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PassengerId = table.Column<int>(type: "int", nullable: false),
                    FlightNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightBookings", x => x.BookingNumber);
                    table.ForeignKey(
                        name: "FK_FlightBookings_Flights_FlightNumber",
                        column: x => x.FlightNumber,
                        principalTable: "Flights",
                        principalColumn: "FlightNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlightBookings_Passengers_PassengerId",
                        column: x => x.PassengerId,
                        principalTable: "Passengers",
                        principalColumn: "PassengerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FlightBookings_FlightNumber",
                table: "FlightBookings",
                column: "FlightNumber");

            migrationBuilder.CreateIndex(
                name: "IX_FlightBookings_PassengerId_FlightNumber",
                table: "FlightBookings",
                columns: new[] { "PassengerId", "FlightNumber" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Flights_DepartureDate_ArrivalDate_DepartureTime_ArrivalTime_DepartureAirport_ArrivalAirport_PassengerLimit",
                table: "Flights",
                columns: new[] { "DepartureDate", "ArrivalDate", "DepartureTime", "ArrivalTime", "DepartureAirport", "ArrivalAirport", "PassengerLimit" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Passengers_Email",
                table: "Passengers",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlightBookings");

            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "Passengers");
        }
    }
}

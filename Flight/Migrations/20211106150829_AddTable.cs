using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Flight.Migrations
{
    public partial class AddTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AirPlanNames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirPlanNames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CompanyAirLines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyAirLines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyAirlineId = table.Column<int>(type: "int", nullable: false),
                    SourceId = table.Column<int>(type: "int", nullable: false),
                    DestinationId = table.Column<int>(type: "int", nullable: false),
                    FlightDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SeatsCount = table.Column<int>(type: "int", nullable: false),
                    AirPlaneNameId = table.Column<int>(type: "int", nullable: false),
                    FlightType = table.Column<int>(type: "int", nullable: false),
                    RateClass = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Flights_AirPlanNames_AirPlaneNameId",
                        column: x => x.AirPlaneNameId,
                        principalTable: "AirPlanNames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Flights_Cities_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Flights_Cities_SourceId",
                        column: x => x.SourceId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Flights_CompanyAirLines_CompanyAirlineId",
                        column: x => x.CompanyAirlineId,
                        principalTable: "CompanyAirLines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    FlightId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Accounts_UserId",
                        column: x => x.UserId,
                        principalTable: "Accounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Flights_FlightId",
                        column: x => x.FlightId,
                        principalTable: "Flights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AirPlanNames",
                columns: new[] { "Id", "CreatedOn", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 11, 6, 18, 38, 28, 949, DateTimeKind.Local).AddTicks(4541), "C130" },
                    { 2, new DateTime(2021, 11, 6, 18, 38, 28, 949, DateTimeKind.Local).AddTicks(5539), "فوکر 100" },
                    { 3, new DateTime(2021, 11, 6, 18, 38, 28, 949, DateTimeKind.Local).AddTicks(5558), "هواپیمای تستی" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CreatedOn", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 11, 6, 18, 38, 28, 944, DateTimeKind.Local).AddTicks(1960), "تهران" },
                    { 2, new DateTime(2021, 11, 6, 18, 38, 28, 947, DateTimeKind.Local).AddTicks(5140), "مشهد" },
                    { 3, new DateTime(2021, 11, 6, 18, 38, 28, 947, DateTimeKind.Local).AddTicks(5189), "رشت" },
                    { 4, new DateTime(2021, 11, 6, 18, 38, 28, 947, DateTimeKind.Local).AddTicks(5196), "اهواز" }
                });

            migrationBuilder.InsertData(
                table: "CompanyAirLines",
                columns: new[] { "Id", "CreatedDate", "Logo", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 11, 6, 18, 38, 28, 949, DateTimeKind.Local).AddTicks(1582), null, "ملکی ایرلاین" },
                    { 2, new DateTime(2021, 11, 6, 18, 38, 28, 949, DateTimeKind.Local).AddTicks(2695), null, "ایران ایر" },
                    { 3, new DateTime(2021, 11, 6, 18, 38, 28, 949, DateTimeKind.Local).AddTicks(2714), null, "ماهان" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Flights_AirPlaneNameId",
                table: "Flights",
                column: "AirPlaneNameId");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_CompanyAirlineId",
                table: "Flights",
                column: "CompanyAirlineId");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_DestinationId",
                table: "Flights",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_SourceId",
                table: "Flights",
                column: "SourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_FlightId",
                table: "Orders",
                column: "FlightId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Flights");

            migrationBuilder.DropTable(
                name: "AirPlanNames");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "CompanyAirLines");
        }
    }
}

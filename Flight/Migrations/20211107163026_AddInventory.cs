using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Flight.Migrations
{
    public partial class AddInventory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeatsCount",
                table: "Flights");

            migrationBuilder.CreateTable(
                name: "Inventories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FlightId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    InStock = table.Column<bool>(type: "bit", nullable: false),
                    Operation = table.Column<bool>(type: "bit", nullable: false),
                    SeatsCount = table.Column<int>(type: "int", nullable: false),
                    CurrentCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inventories_Flights_FlightId",
                        column: x => x.FlightId,
                        principalTable: "Flights",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AirPlanNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 7, 20, 0, 25, 136, DateTimeKind.Local).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "AirPlanNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 7, 20, 0, 25, 136, DateTimeKind.Local).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "AirPlanNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 7, 20, 0, 25, 136, DateTimeKind.Local).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 7, 20, 0, 25, 131, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 7, 20, 0, 25, 134, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 7, 20, 0, 25, 134, DateTimeKind.Local).AddTicks(8416));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 7, 20, 0, 25, 134, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "CompanyAirLines",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 7, 20, 0, 25, 136, DateTimeKind.Local).AddTicks(3705));

            migrationBuilder.UpdateData(
                table: "CompanyAirLines",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 7, 20, 0, 25, 136, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "CompanyAirLines",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 7, 20, 0, 25, 136, DateTimeKind.Local).AddTicks(4713));

            migrationBuilder.CreateIndex(
                name: "IX_Inventories_FlightId",
                table: "Inventories",
                column: "FlightId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Inventories");

            migrationBuilder.AddColumn<int>(
                name: "SeatsCount",
                table: "Flights",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AirPlanNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 6, 19, 7, 29, 987, DateTimeKind.Local).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "AirPlanNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 6, 19, 7, 29, 987, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "AirPlanNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 6, 19, 7, 29, 987, DateTimeKind.Local).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 6, 19, 7, 29, 978, DateTimeKind.Local).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 6, 19, 7, 29, 985, DateTimeKind.Local).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 6, 19, 7, 29, 985, DateTimeKind.Local).AddTicks(691));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 6, 19, 7, 29, 985, DateTimeKind.Local).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "CompanyAirLines",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 6, 19, 7, 29, 987, DateTimeKind.Local).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "CompanyAirLines",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 6, 19, 7, 29, 987, DateTimeKind.Local).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "CompanyAirLines",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 6, 19, 7, 29, 987, DateTimeKind.Local).AddTicks(5059));
        }
    }
}

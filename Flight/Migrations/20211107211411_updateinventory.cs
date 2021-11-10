using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Flight.Migrations
{
    public partial class updateinventory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Operation",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "SeatsCount",
                table: "Inventories");

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
                value: new DateTime(2021, 11, 8, 0, 44, 10, 418, DateTimeKind.Local).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "AirPlanNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 8, 0, 44, 10, 418, DateTimeKind.Local).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "AirPlanNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 8, 0, 44, 10, 418, DateTimeKind.Local).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 8, 0, 44, 10, 399, DateTimeKind.Local).AddTicks(293));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 8, 0, 44, 10, 406, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 8, 0, 44, 10, 406, DateTimeKind.Local).AddTicks(2255));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 8, 0, 44, 10, 406, DateTimeKind.Local).AddTicks(2269));

            migrationBuilder.UpdateData(
                table: "CompanyAirLines",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 8, 0, 44, 10, 414, DateTimeKind.Local).AddTicks(5604));

            migrationBuilder.UpdateData(
                table: "CompanyAirLines",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 8, 0, 44, 10, 414, DateTimeKind.Local).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "CompanyAirLines",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 8, 0, 44, 10, 414, DateTimeKind.Local).AddTicks(7368));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeatsCount",
                table: "Flights");

            migrationBuilder.AddColumn<bool>(
                name: "Operation",
                table: "Inventories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "SeatsCount",
                table: "Inventories",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
        }
    }
}

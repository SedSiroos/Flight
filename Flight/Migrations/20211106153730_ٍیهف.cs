using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Flight.Migrations
{
    public partial class _ٍیهف : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FlightDate",
                table: "Flights",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "FlightDate",
                table: "Flights",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AirPlanNames",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 6, 18, 38, 28, 949, DateTimeKind.Local).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "AirPlanNames",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 6, 18, 38, 28, 949, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "AirPlanNames",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 6, 18, 38, 28, 949, DateTimeKind.Local).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 6, 18, 38, 28, 944, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 6, 18, 38, 28, 947, DateTimeKind.Local).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 6, 18, 38, 28, 947, DateTimeKind.Local).AddTicks(5189));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 11, 6, 18, 38, 28, 947, DateTimeKind.Local).AddTicks(5196));

            migrationBuilder.UpdateData(
                table: "CompanyAirLines",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 6, 18, 38, 28, 949, DateTimeKind.Local).AddTicks(1582));

            migrationBuilder.UpdateData(
                table: "CompanyAirLines",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 6, 18, 38, 28, 949, DateTimeKind.Local).AddTicks(2695));

            migrationBuilder.UpdateData(
                table: "CompanyAirLines",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2021, 11, 6, 18, 38, 28, 949, DateTimeKind.Local).AddTicks(2714));
        }
    }
}

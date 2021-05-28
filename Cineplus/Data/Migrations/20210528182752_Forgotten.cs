using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cineplus.Data.Migrations
{
    public partial class Forgotten : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reproduction",
                keyColumn: "Id",
                keyValue: -5,
                column: "StartTime",
                value: new DateTime(2021, 5, 28, 14, 27, 51, 300, DateTimeKind.Local).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "Reproduction",
                keyColumn: "Id",
                keyValue: -4,
                column: "StartTime",
                value: new DateTime(2021, 5, 28, 14, 27, 51, 300, DateTimeKind.Local).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "Reproduction",
                keyColumn: "Id",
                keyValue: -3,
                column: "StartTime",
                value: new DateTime(2021, 5, 28, 14, 27, 51, 300, DateTimeKind.Local).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "Reproduction",
                keyColumn: "Id",
                keyValue: -2,
                column: "StartTime",
                value: new DateTime(2021, 5, 28, 14, 27, 51, 300, DateTimeKind.Local).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "Reproduction",
                keyColumn: "Id",
                keyValue: -1,
                column: "StartTime",
                value: new DateTime(2021, 5, 28, 14, 27, 51, 295, DateTimeKind.Local).AddTicks(9158));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Reproduction",
                keyColumn: "Id",
                keyValue: -5,
                column: "StartTime",
                value: new DateTime(2021, 5, 28, 6, 31, 10, 847, DateTimeKind.Local).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "Reproduction",
                keyColumn: "Id",
                keyValue: -4,
                column: "StartTime",
                value: new DateTime(2021, 5, 28, 6, 31, 10, 847, DateTimeKind.Local).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "Reproduction",
                keyColumn: "Id",
                keyValue: -3,
                column: "StartTime",
                value: new DateTime(2021, 5, 28, 6, 31, 10, 847, DateTimeKind.Local).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "Reproduction",
                keyColumn: "Id",
                keyValue: -2,
                column: "StartTime",
                value: new DateTime(2021, 5, 28, 6, 31, 10, 847, DateTimeKind.Local).AddTicks(925));

            migrationBuilder.UpdateData(
                table: "Reproduction",
                keyColumn: "Id",
                keyValue: -1,
                column: "StartTime",
                value: new DateTime(2021, 5, 28, 6, 31, 10, 843, DateTimeKind.Local).AddTicks(7245));
        }
    }
}

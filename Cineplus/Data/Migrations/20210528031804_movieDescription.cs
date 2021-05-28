using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cineplus.Data.Migrations
{
    public partial class movieDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Movie",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Reproduction",
                keyColumn: "Id",
                keyValue: -5,
                column: "StartTime",
                value: new DateTime(2021, 5, 27, 23, 18, 3, 128, DateTimeKind.Local).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "Reproduction",
                keyColumn: "Id",
                keyValue: -4,
                column: "StartTime",
                value: new DateTime(2021, 5, 27, 23, 18, 3, 128, DateTimeKind.Local).AddTicks(5789));

            migrationBuilder.UpdateData(
                table: "Reproduction",
                keyColumn: "Id",
                keyValue: -3,
                column: "StartTime",
                value: new DateTime(2021, 5, 27, 23, 18, 3, 128, DateTimeKind.Local).AddTicks(5782));

            migrationBuilder.UpdateData(
                table: "Reproduction",
                keyColumn: "Id",
                keyValue: -2,
                column: "StartTime",
                value: new DateTime(2021, 5, 27, 23, 18, 3, 128, DateTimeKind.Local).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "Reproduction",
                keyColumn: "Id",
                keyValue: -1,
                column: "StartTime",
                value: new DateTime(2021, 5, 27, 23, 18, 3, 124, DateTimeKind.Local).AddTicks(4161));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Movie");

            migrationBuilder.UpdateData(
                table: "Reproduction",
                keyColumn: "Id",
                keyValue: -5,
                column: "StartTime",
                value: new DateTime(2021, 5, 26, 21, 43, 29, 659, DateTimeKind.Local).AddTicks(2829));

            migrationBuilder.UpdateData(
                table: "Reproduction",
                keyColumn: "Id",
                keyValue: -4,
                column: "StartTime",
                value: new DateTime(2021, 5, 26, 21, 43, 29, 659, DateTimeKind.Local).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "Reproduction",
                keyColumn: "Id",
                keyValue: -3,
                column: "StartTime",
                value: new DateTime(2021, 5, 26, 21, 43, 29, 659, DateTimeKind.Local).AddTicks(2815));

            migrationBuilder.UpdateData(
                table: "Reproduction",
                keyColumn: "Id",
                keyValue: -2,
                column: "StartTime",
                value: new DateTime(2021, 5, 26, 21, 43, 29, 659, DateTimeKind.Local).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "Reproduction",
                keyColumn: "Id",
                keyValue: -1,
                column: "StartTime",
                value: new DateTime(2021, 5, 26, 21, 43, 29, 653, DateTimeKind.Local).AddTicks(7261));
        }
    }
}

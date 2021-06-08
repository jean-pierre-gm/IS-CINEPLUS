using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cineplus.Data.Migrations
{
    public partial class Discounts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "PersonalDiscount",
                type: "TEXT",
                maxLength: 15,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "DateDiscount",
                columns: new[] { "Id", "Date", "Description", "Discount", "Enable" },
                values: new object[] { -1, new DateTime(2021, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Descuento del dia del trabajador", 10.0, true });

            migrationBuilder.InsertData(
                table: "DateDiscount",
                columns: new[] { "Id", "Date", "Description", "Discount", "Enable" },
                values: new object[] { -2, new DateTime(2021, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Descuento del dia de la lengua española", 10.0, true });

            migrationBuilder.InsertData(
                table: "DateDiscount",
                columns: new[] { "Id", "Date", "Description", "Discount", "Enable" },
                values: new object[] { -3, new DateTime(2021, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Descuento del dia del No", 10.0, true });

            migrationBuilder.InsertData(
                table: "PersonalDiscount",
                columns: new[] { "Id", "Description", "Discount", "Enable", "Name" },
                values: new object[] { -1, "Descuento para los integrantes de la FEU", 10.0, true, "FEU" });

            migrationBuilder.InsertData(
                table: "PersonalDiscount",
                columns: new[] { "Id", "Description", "Discount", "Enable", "Name" },
                values: new object[] { -2, "Descuento para los discapacitados", 10.0, true, "Discapacitados" });

            migrationBuilder.InsertData(
                table: "PersonalDiscount",
                columns: new[] { "Id", "Description", "Discount", "Enable", "Name" },
                values: new object[] { -3, "Descuento para los trabajadores del centro", 50.0, true, "Personal" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DateDiscount",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "DateDiscount",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "DateDiscount",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "PersonalDiscount",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "PersonalDiscount",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "PersonalDiscount",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "PersonalDiscount",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 15);
        }
    }
}

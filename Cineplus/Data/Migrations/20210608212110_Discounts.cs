using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cineplus.Data.Migrations
{
    public partial class Discounts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Points",
                table: "Associate",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateTable(
                name: "DateDiscount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Discount = table.Column<double>(type: "REAL", nullable: false),
                    Enable = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateDiscount", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonalDiscount",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PersonalName = table.Column<string>(type: "TEXT", maxLength: 15, nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    Discount = table.Column<double>(type: "REAL", nullable: false),
                    Enable = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalDiscount", x => x.Id);
                });

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
                columns: new[] { "Id", "Description", "Discount", "Enable", "PersonalName" },
                values: new object[] { -1, "Descuento para los integrantes de la FEU", 10.0, true, "FEU" });

            migrationBuilder.InsertData(
                table: "PersonalDiscount",
                columns: new[] { "Id", "Description", "Discount", "Enable", "PersonalName" },
                values: new object[] { -2, "Descuento para los discapacitados", 10.0, true, "Discapacitados" });

            migrationBuilder.InsertData(
                table: "PersonalDiscount",
                columns: new[] { "Id", "Description", "Discount", "Enable", "PersonalName" },
                values: new object[] { -3, "Descuento para los trabajadores del centro", 50.0, true, "Personal" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DateDiscount");

            migrationBuilder.DropTable(
                name: "PersonalDiscount");

            migrationBuilder.AlterColumn<int>(
                name: "Points",
                table: "Associate",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldDefaultValue: 0);
        }
    }
}

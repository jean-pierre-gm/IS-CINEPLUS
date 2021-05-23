using Microsoft.EntityFrameworkCore.Migrations;

namespace Cineplus.Data.Migrations
{
    public partial class TheaterDimensions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Capacity",
                table: "Theater",
                newName: "Rows");

            migrationBuilder.AddColumn<int>(
                name: "Columns",
                table: "Theater",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Columns",
                table: "Theater");

            migrationBuilder.RenameColumn(
                name: "Rows",
                table: "Theater",
                newName: "Capacity");
        }
    }
}

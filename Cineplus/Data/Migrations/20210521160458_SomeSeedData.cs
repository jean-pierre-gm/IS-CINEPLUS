using Microsoft.EntityFrameworkCore.Migrations;

namespace Cineplus.Data.Migrations
{
    public partial class SomeSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "Description", "GenreName" },
                values: new object[] { -1, "This movies try to make people laugh.", "Comedy" });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Director", "Duration", "GenreId", "MovieName", "Score" },
                values: new object[] { -1, "Pedro Pérez", 134, -1, "Los 3 de la loma", 0.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}

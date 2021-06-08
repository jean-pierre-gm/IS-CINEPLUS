using Microsoft.EntityFrameworkCore.Migrations;

namespace Cineplus.Data.Migrations
{
    public partial class SeedGenreAndMovies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "Description", "GenreName" },
                values: new object[] { -2, "Guns and guns", "Action" });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: -1,
                column: "Score",
                value: 7.8000001907348633);

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Director", "Duration", "GenreId", "MovieName", "Score" },
                values: new object[] { -2, "Alfredo Jul", 113, -1, "Donde cayó la tiza", 9.0 });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Director", "Duration", "GenreId", "MovieName", "Score" },
                values: new object[] { -3, "Alain Serdán", 130, -2, "Dos es mejor que uno", 0.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: -1,
                column: "Score",
                value: 0.0);
        }
    }
}

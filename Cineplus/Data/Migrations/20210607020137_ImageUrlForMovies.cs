using Microsoft.EntityFrameworkCore.Migrations;

namespace Cineplus.Data.Migrations
{
    public partial class ImageUrlForMovies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Movie",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "Description", "GenreName" },
                values: new object[] { -3, "Making drama", "Drama" });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "Description", "Director", "Duration", "ImageUrl", "MovieName", "Score" },
                values: new object[] { "When an unexpected enemy emerges and threatens global safety and security, Nick Fury, director of the international peacekeeping agency known as S.H.I.E.L.D., finds himself in need of a team to pull the world back from the brink of disaster. Spanning the globe, a daring recruitment effort begins!", "Joss Whedon", 143, "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/RYMX2wcKCBAr24UyPD7xwmjaTn.jpg", "The Avengers", 7.6999998092651367 });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "Description", "Director", "Duration", "GenreId", "ImageUrl", "MovieName", "Score" },
                values: new object[] { "When Dr. Henry Jones Sr. suddenly goes missing while pursuing the Holy Grail, eminent archaeologist Indiana must team up with Marcus Brody, Sallah and Elsa Schneider to follow in his father's footsteps and stop the Nazis from recovering the power of eternal life.", "Steven Spielberg", 127, -2, "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/osKZUgKRUK1jwYMdsmlevK7zZIY.jpg", "Indiana Jones and the Last Crusade", 7.8000001907348633 });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Description", "Director", "Duration", "GenreId", "ImageUrl", "MovieName", "Score" },
                values: new object[] { "A man with a low IQ has accomplished great things in his life and been present during significant historic events—in each case, far exceeding what anyone imagined he could do. But despite all he has achieved, his one true love eludes him.", "Robert Zemeckis", 142, -3, "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/h5J4W4veyxMXDMjeNxZI46TsHOb.jpg", "Forrest Gump", 8.8000001907348633 });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Description", "Director", "Duration", "GenreId", "ImageUrl", "MovieName", "Score" },
                values: new object[] { -4, "To take down South Boston's Irish Mafia, the police send in one of their own to infiltrate the underworld, not realizing the syndicate has done likewise. While an undercover cop curries favor with the mob kingpin, a career criminal rises through the police ranks. But both sides soon discover there's a mole among them.", "Martin Scorsese", 149, -3, "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/kWWAt2FMRbqLFFy8o5R4Zr8cMAb.jpg", "The Departed", 8.1999998092651367 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Movie");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "Description", "Director", "Duration", "MovieName", "Score" },
                values: new object[] { null, "Alain Serdán", 130, "Dos es mejor que uno", 0.0 });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "Description", "Director", "Duration", "GenreId", "MovieName", "Score" },
                values: new object[] { null, "Alfredo Jul", 113, -1, "Donde cayó la tiza", 9.0 });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Description", "Director", "Duration", "GenreId", "MovieName", "Score" },
                values: new object[] { null, "Pedro Pérez", 134, -1, "Los 3 de la loma", 7.8000001907348633 });
        }
    }
}

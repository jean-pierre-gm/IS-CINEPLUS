using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cineplus.Data.Migrations
{
    public partial class ActorsAndCountries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Capacity",
                table: "Theater",
                newName: "Rows");

            migrationBuilder.AddColumn<bool>(
                name: "Confirmed",
                table: "Ticket",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "PointsPrice",
                table: "Ticket",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Ticket",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReserveTime",
                table: "Ticket",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Columns",
                table: "Theater",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Reproduction",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Movie",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Movie",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Display",
                table: "Movie",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Movie",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Actor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ActorName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Active = table.Column<bool>(type: "INTEGER", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActorMovie",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ActorId = table.Column<int>(type: "INTEGER", nullable: false),
                    MovieId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorMovie", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActorMovie_Actor_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorMovie_Movie_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actor",
                columns: new[] { "Id", "ActorName" },
                values: new object[] { -1, "Tom Hanks" });

            migrationBuilder.InsertData(
                table: "Actor",
                columns: new[] { "Id", "ActorName" },
                values: new object[] { -25, "Vladimir Cruz" });

            migrationBuilder.InsertData(
                table: "Actor",
                columns: new[] { "Id", "ActorName" },
                values: new object[] { -24, "Jorge Perugorría" });

            migrationBuilder.InsertData(
                table: "Actor",
                columns: new[] { "Id", "ActorName" },
                values: new object[] { -23, "Michael Nyqvist" });

            migrationBuilder.InsertData(
                table: "Actor",
                columns: new[] { "Id", "ActorName" },
                values: new object[] { -22, "Keanu Reeves" });

            migrationBuilder.InsertData(
                table: "Actor",
                columns: new[] { "Id", "ActorName" },
                values: new object[] { -21, "Samuel L. Jackson" });

            migrationBuilder.InsertData(
                table: "Actor",
                columns: new[] { "Id", "ActorName" },
                values: new object[] { -19, "Mone Kamishiraishi" });

            migrationBuilder.InsertData(
                table: "Actor",
                columns: new[] { "Id", "ActorName" },
                values: new object[] { -18, "Ryunosuke Kamiki" });

            migrationBuilder.InsertData(
                table: "Actor",
                columns: new[] { "Id", "ActorName" },
                values: new object[] { -17, "Marlon Brando" });

            migrationBuilder.InsertData(
                table: "Actor",
                columns: new[] { "Id", "ActorName" },
                values: new object[] { -16, "Al Pacino" });

            migrationBuilder.InsertData(
                table: "Actor",
                columns: new[] { "Id", "ActorName" },
                values: new object[] { -15, "Morgan Freeman" });

            migrationBuilder.InsertData(
                table: "Actor",
                columns: new[] { "Id", "ActorName" },
                values: new object[] { -14, "Tim Robbins" });

            migrationBuilder.InsertData(
                table: "Actor",
                columns: new[] { "Id", "ActorName" },
                values: new object[] { -20, "John Travolta" });

            migrationBuilder.InsertData(
                table: "Actor",
                columns: new[] { "Id", "ActorName" },
                values: new object[] { -12, "Emma Stone" });

            migrationBuilder.InsertData(
                table: "Actor",
                columns: new[] { "Id", "ActorName" },
                values: new object[] { -11, "Ryan Gosling" });

            migrationBuilder.InsertData(
                table: "Actor",
                columns: new[] { "Id", "ActorName" },
                values: new object[] { -10, "Josh Hutcherson" });

            migrationBuilder.InsertData(
                table: "Actor",
                columns: new[] { "Id", "ActorName" },
                values: new object[] { -9, "Jennifer Lawrence" });

            migrationBuilder.InsertData(
                table: "Actor",
                columns: new[] { "Id", "ActorName" },
                values: new object[] { -8, "Leonardo DiCaprio" });

            migrationBuilder.InsertData(
                table: "Actor",
                columns: new[] { "Id", "ActorName" },
                values: new object[] { -7, "Jack Nicholson" });

            migrationBuilder.InsertData(
                table: "Actor",
                columns: new[] { "Id", "ActorName" },
                values: new object[] { -6, "Chris Evans" });

            migrationBuilder.InsertData(
                table: "Actor",
                columns: new[] { "Id", "ActorName" },
                values: new object[] { -5, "Robert Downey Jr." });

            migrationBuilder.InsertData(
                table: "Actor",
                columns: new[] { "Id", "ActorName" },
                values: new object[] { -4, "Sean Connery" });

            migrationBuilder.InsertData(
                table: "Actor",
                columns: new[] { "Id", "ActorName" },
                values: new object[] { -3, "Harrison Ford" });

            migrationBuilder.InsertData(
                table: "Actor",
                columns: new[] { "Id", "ActorName" },
                values: new object[] { -2, "Robin Wright" });

            migrationBuilder.InsertData(
                table: "Actor",
                columns: new[] { "Id", "ActorName" },
                values: new object[] { -13, "Emma Thompson" });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "Description", "GenreName" },
                values: new object[] { -5, "Doing ilegal stuff", "Crime" });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "Description", "GenreName" },
                values: new object[] { -4, "All made up", "Science Fiction" });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "Description", "GenreName" },
                values: new object[] { -3, "Making drama", "Drama" });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "Country", "Description", "Director", "Display", "Duration", "ImageUrl", "MovieName", "Score" },
                values: new object[] { "US", "When an unexpected enemy emerges and threatens global safety and security, Nick Fury, director of the international peacekeeping agency known as S.H.I.E.L.D., finds himself in need of a team to pull the world back from the brink of disaster. Spanning the globe, a daring recruitment effort begins!", "Joss Whedon", new DateTime(2021, 6, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), 143, "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/RYMX2wcKCBAr24UyPD7xwmjaTn.jpg", "The Avengers", 7.6999998092651367 });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "Country", "Description", "Director", "Display", "Duration", "GenreId", "ImageUrl", "MovieName", "Score" },
                values: new object[] { "US", "When Dr. Henry Jones Sr. suddenly goes missing while pursuing the Holy Grail, eminent archaeologist Indiana must team up with Marcus Brody, Sallah and Elsa Schneider to follow in his father's footsteps and stop the Nazis from recovering the power of eternal life.", "Steven Spielberg", new DateTime(2021, 6, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), 127, -2, "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/osKZUgKRUK1jwYMdsmlevK7zZIY.jpg", "Indiana Jones and the Last Crusade", 7.8000001907348633 });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Country", "Description", "Director", "Display", "Duration", "GenreId", "ImageUrl", "MovieName", "Score" },
                values: new object[] { -7, "US", "In 1970s London amidst the punk rock revolution, a young grifter named Estella is determined to make a name for herself with her designs. She befriends a pair of young thieves who appreciate her appetite for mischief, and together they are able to build a life for themselves on the London streets. One day, Estella’s flair for fashion catches the eye of the Baroness von Hellman, a fashion legend who is devastatingly chic and terrifyingly haute. But their relationship sets in motion a course of events and revelations that will cause Estella to embrace her wicked side and become the raucous, fashionable and revenge-bent Cruella.", "Craig Gillespie", new DateTime(2021, 6, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), 134, -1, "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/A0knvX7rlwTyZSKj8H5NiARb45.jpg", "Cruella", 8.6999998092651367 });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Country", "Description", "Director", "Display", "Duration", "GenreId", "ImageUrl", "MovieName", "Score" },
                values: new object[] { -12, "US", "Ex-hitman John Wick comes out of retirement to track down the gangsters that took everything from him.", "Chad Stahelski", new DateTime(2021, 6, 4, 15, 0, 0, 0, DateTimeKind.Unspecified), 101, -2, "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/fZPSd91yGE9fCcCe6OoQr6E3Bev.jpg", "John Wick", 7.3000001907348633 });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Country", "Description", "Director", "Display", "Duration", "GenreId", "ImageUrl", "MovieName", "Score" },
                values: new object[] { -13, "CU", "Havana, Cuba, 1979. Flamboyantly gay artist Diego (Jorge Perugorría) attempts to seduce the straight and strait-laced David, an idealistic young communist, and fails dismally. But David conspires to become friends with Diego so he can monitor the artist's subversive life for the state. As Diego and David discuss politics, individuality and personal expression in Castro's Cuba, a genuine friendship develops between the two. But can it last? Strawberry and Chocolate became an instant hit when it was released, and has become a classic of Cuban cinema due to its charming and authentic exploration of a connection between two people under historical circumstances that seem levelled against them.", "Tomás Gutiérrez Alea", new DateTime(2021, 5, 4, 15, 0, 0, 0, DateTimeKind.Unspecified), 108, -1, "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/tMwUsu080E4kS4rkHPffy1ugvaJ.jpg", "Strawberry and Chocolate", 7.3000001907348633 });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "Active", "Name", "Type" },
                values: new object[] { -1, false, "Best Reviews", "Display" });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "Active", "Name", "Type" },
                values: new object[] { -2, true, "Manual", "Display" });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "Active", "Name", "Type" },
                values: new object[] { -3, false, "Random", "Display" });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "Active", "Name", "Type" },
                values: new object[] { -4, false, "Most seen", "Display" });

            migrationBuilder.InsertData(
                table: "Theater",
                columns: new[] { "Id", "Columns", "Rows" },
                values: new object[] { -1, 10, 15 });

            migrationBuilder.InsertData(
                table: "Theater",
                columns: new[] { "Id", "Columns", "Rows" },
                values: new object[] { -2, 10, 10 });

            migrationBuilder.InsertData(
                table: "Theater",
                columns: new[] { "Id", "Columns", "Rows" },
                values: new object[] { -3, 5, 5 });

            migrationBuilder.InsertData(
                table: "ActorMovie",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[] { -1, -1, -1 });

            migrationBuilder.InsertData(
                table: "ActorMovie",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[] { -2, -2, -1 });

            migrationBuilder.InsertData(
                table: "ActorMovie",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[] { -3, -3, -2 });

            migrationBuilder.InsertData(
                table: "ActorMovie",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[] { -4, -4, -2 });

            migrationBuilder.InsertData(
                table: "ActorMovie",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[] { -5, -5, -3 });

            migrationBuilder.InsertData(
                table: "ActorMovie",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[] { -6, -6, -3 });

            migrationBuilder.InsertData(
                table: "ActorMovie",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[] { -26, -25, -13 });

            migrationBuilder.InsertData(
                table: "ActorMovie",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[] { -25, -24, -13 });

            migrationBuilder.InsertData(
                table: "ActorMovie",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[] { -24, -23, -12 });

            migrationBuilder.InsertData(
                table: "ActorMovie",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[] { -23, -22, -12 });

            migrationBuilder.InsertData(
                table: "ActorMovie",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[] { -14, -13, -7 });

            migrationBuilder.InsertData(
                table: "ActorMovie",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[] { -13, -12, -7 });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Country", "Description", "Director", "Display", "Duration", "GenreId", "ImageUrl", "MovieName", "Score" },
                values: new object[] { "US", "A man with a low IQ has accomplished great things in his life and been present during significant historic events—in each case, far exceeding what anyone imagined he could do. But despite all he has achieved, his one true love eludes him.", "Robert Zemeckis", new DateTime(2021, 6, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), 142, -3, "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/h5J4W4veyxMXDMjeNxZI46TsHOb.jpg", "Forrest Gump", 8.8000001907348633 });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Country", "Description", "Director", "Display", "Duration", "GenreId", "ImageUrl", "MovieName", "Score" },
                values: new object[] { -10, "JP", "High schoolers Mitsuha and Taki are complete strangers living separate lives. But one night, they suddenly switch places. Mitsuha wakes up in Taki’s body, and he in hers. This bizarre occurrence continues to happen randomly, and the two must adjust their lives around each other.", "Makoto Shinkai", new DateTime(2021, 6, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), 104, -3, "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/q719jXXEzOoYaps6babgKnONONX.jpg", "Your Name.", 8.6000003814697266 });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Country", "Description", "Director", "Display", "Duration", "GenreId", "ImageUrl", "MovieName", "Score" },
                values: new object[] { -5, "US", "Katniss Everdeen reluctantly becomes the symbol of a mass rebellion against the autocratic Capitol.", "Francis Lawrence", new DateTime(2021, 6, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), 123, -4, "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/4FAA18ZIja70d1Tu5hr5cj2q1sB.jpg", "The Hunger Games: Mockingjay - Part 1", 6.8000001907348633 });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Country", "Description", "Director", "Display", "Duration", "GenreId", "ImageUrl", "MovieName", "Score" },
                values: new object[] { -9, "US", "Spanning the years 1945 to 1955, a chronicle of the fictional Italian-American Corleone crime family. When organized crime family patriarch, Vito Corleone barely survives an attempt on his life, his youngest son, Michael steps in to take care of the would-be killers, launching a campaign of bloody revenge.", "Francis Ford Coppola", new DateTime(2021, 6, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), 175, -3, "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/3bhkrj58Vtu7enYsRolD1fZdja1.jpg", "The Godfather", 8.6999998092651367 });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Country", "Description", "Director", "Display", "Duration", "GenreId", "ImageUrl", "MovieName", "Score" },
                values: new object[] { -8, "US", "Framed in the 1940s for the double murder of his wife and her lover, upstanding banker Andy Dufresne begins a new life at the Shawshank prison, where he puts his accounting skills to work for an amoral warden. During his long stretch in prison, Dufresne comes to be admired by the other inmates -- including an older prisoner named Red -- for his integrity and unquenchable sense of hope.", "Frank Darabont", new DateTime(2021, 6, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), 144, -3, "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/q6y0Go1tsGEsmtFryDOJo3dEmqu.jpg", "The Shawshank Redemption", 8.6999998092651367 });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Country", "Description", "Director", "Display", "Duration", "GenreId", "ImageUrl", "MovieName", "Score" },
                values: new object[] { -6, "US", "Mia, an aspiring actress, serves lattes to movie stars in between auditions and Sebastian, a jazz musician, scrapes by playing cocktail party gigs in dingy bars, but as success mounts they are faced with decisions that begin to fray the fragile fabric of their love affair, and the dreams they worked so hard to maintain in each other threaten to rip them apart.", "Damien Chazelle", new DateTime(2021, 6, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), 129, -3, "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/uDO8zWDhfWwoFdKS4fzkUJt0Rf0.jpg", "La La Land", 7.9000000953674316 });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Country", "Description", "Director", "Display", "Duration", "GenreId", "ImageUrl", "MovieName", "Score" },
                values: new object[] { -4, "US", "To take down South Boston's Irish Mafia, the police send in one of their own to infiltrate the underworld, not realizing the syndicate has done likewise. While an undercover cop curries favor with the mob kingpin, a career criminal rises through the police ranks. But both sides soon discover there's a mole among them.", "Martin Scorsese", new DateTime(2021, 6, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), 149, -3, "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/kWWAt2FMRbqLFFy8o5R4Zr8cMAb.jpg", "The Departed", 8.1999998092651367 });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Country", "Description", "Director", "Display", "Duration", "GenreId", "ImageUrl", "MovieName", "Score" },
                values: new object[] { -11, "US", "A burger-loving hit man, his philosophical partner, a drug-addled gangster's moll and a washed-up boxer converge in this sprawling, comedic crime caper. Their adventures unfurl in three stories that ingeniously trip back and forth in time.", "Makoto Shinkai", new DateTime(2021, 6, 4, 15, 0, 0, 0, DateTimeKind.Unspecified), 154, -5, "https://www.themoviedb.org/t/p/w600_and_h900_bestv2/d5iIlFn5s0ImszYzBPb8JPIfbXD.jpg", "Pulp Fiction", 8.6000003814697266 });

            migrationBuilder.InsertData(
                table: "Reproduction",
                columns: new[] { "Id", "MovieId", "Price", "StartTime", "TheaterId" },
                values: new object[] { -4, -1, 8.0, new DateTime(2021, 6, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), -3 });

            migrationBuilder.InsertData(
                table: "Reproduction",
                columns: new[] { "Id", "MovieId", "Price", "StartTime", "TheaterId" },
                values: new object[] { -3, -1, 9.0, new DateTime(2021, 6, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), -2 });

            migrationBuilder.InsertData(
                table: "Reproduction",
                columns: new[] { "Id", "MovieId", "Price", "StartTime", "TheaterId" },
                values: new object[] { -5, -1, 14.0, new DateTime(2021, 6, 6, 22, 0, 0, 0, DateTimeKind.Unspecified), -3 });

            migrationBuilder.InsertData(
                table: "Reproduction",
                columns: new[] { "Id", "MovieId", "Price", "StartTime", "TheaterId" },
                values: new object[] { -1, -1, 10.0, new DateTime(2021, 6, 6, 18, 0, 0, 0, DateTimeKind.Unspecified), -1 });

            migrationBuilder.InsertData(
                table: "Reproduction",
                columns: new[] { "Id", "MovieId", "Price", "StartTime", "TheaterId" },
                values: new object[] { -2, -1, 12.0, new DateTime(2021, 6, 6, 22, 0, 0, 0, DateTimeKind.Unspecified), -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -142, 1, 14, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -187, 6, 3, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -186, 5, 3, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -185, 4, 3, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -184, 3, 3, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -188, 7, 3, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -183, 2, 3, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -181, 0, 3, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -180, 9, 2, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -179, 8, 2, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -178, 7, 2, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -177, 6, 2, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -176, 5, 2, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -182, 1, 3, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -189, 8, 3, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -190, 9, 3, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -191, 0, 4, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -192, 1, 4, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -193, 2, 4, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -194, 3, 4, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -195, 4, 4, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -196, 5, 4, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -197, 6, 4, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -198, 7, 4, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -199, 8, 4, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -200, 9, 4, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -201, 0, 5, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -202, 1, 5, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -203, 2, 5, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -204, 3, 5, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -175, 4, 2, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -174, 3, 2, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -172, 1, 2, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -141, 0, 14, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -143, 2, 14, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -144, 3, 14, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -145, 4, 14, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -146, 5, 14, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -147, 6, 14, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -148, 7, 14, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -149, 8, 14, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -150, 9, 14, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -151, 0, 0, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -152, 1, 0, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -153, 2, 0, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -154, 3, 0, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -155, 4, 0, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -156, 5, 0, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -173, 2, 2, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -157, 6, 0, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -159, 8, 0, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -160, 9, 0, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -161, 0, 1, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -162, 1, 1, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -205, 4, 5, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -163, 2, 1, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -164, 3, 1, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -165, 4, 1, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -166, 5, 1, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -167, 6, 1, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -168, 7, 1, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -169, 8, 1, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -170, 9, 1, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -171, 0, 2, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -158, 7, 0, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -206, 5, 5, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -218, 7, 6, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -208, 7, 5, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -244, 3, 9, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -245, 4, 9, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -246, 5, 9, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -247, 6, 9, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -248, 7, 9, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -249, 8, 9, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -250, 9, 9, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -251, 0, 0, -3 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -252, 1, 0, -3 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -253, 2, 0, -3 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -254, 3, 0, -3 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -255, 4, 0, -3 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -256, 0, 1, -3 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -257, 1, 1, -3 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -243, 2, 9, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -258, 2, 1, -3 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -260, 4, 1, -3 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -261, 0, 2, -3 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -262, 1, 2, -3 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -263, 2, 2, -3 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -264, 3, 2, -3 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -265, 4, 2, -3 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -266, 0, 3, -3 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -267, 1, 3, -3 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -268, 2, 3, -3 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -269, 3, 3, -3 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -270, 4, 3, -3 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -271, 0, 4, -3 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -272, 1, 4, -3 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -273, 2, 4, -3 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -259, 3, 1, -3 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -242, 1, 9, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -241, 0, 9, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -240, 9, 8, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -209, 8, 5, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -210, 9, 5, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -211, 0, 6, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -212, 1, 6, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -213, 2, 6, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -214, 3, 6, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -215, 4, 6, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -216, 5, 6, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -217, 6, 6, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -140, 9, 13, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -219, 8, 6, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -220, 9, 6, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -221, 0, 7, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -222, 1, 7, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -223, 2, 7, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -224, 3, 7, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -225, 4, 7, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -239, 8, 8, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -238, 7, 8, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -237, 6, 8, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -236, 5, 8, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -235, 4, 8, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -234, 3, 8, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -207, 6, 5, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -233, 2, 8, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -231, 0, 8, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -230, 9, 7, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -229, 8, 7, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -228, 7, 7, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -227, 6, 7, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -226, 5, 7, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -232, 1, 8, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -139, 8, 13, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -128, 7, 12, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -137, 6, 13, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -36, 5, 3, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -37, 6, 3, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -38, 7, 3, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -39, 8, 3, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -40, 9, 3, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -41, 0, 4, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -42, 1, 4, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -43, 2, 4, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -44, 3, 4, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -45, 4, 4, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -46, 5, 4, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -47, 6, 4, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -48, 7, 4, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -49, 8, 4, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -50, 9, 4, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -51, 0, 5, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -52, 1, 5, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -66, 5, 6, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -65, 4, 6, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -64, 3, 6, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -63, 2, 6, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -62, 1, 6, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -61, 0, 6, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -35, 4, 3, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -60, 9, 5, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -58, 7, 5, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -57, 6, 5, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -56, 5, 5, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -55, 4, 5, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -54, 3, 5, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -53, 2, 5, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -59, 8, 5, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -67, 6, 6, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -34, 3, 3, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -32, 1, 3, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -1, 0, 0, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -2, 1, 0, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -3, 2, 0, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -4, 3, 0, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -5, 4, 0, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -6, 5, 0, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -7, 6, 0, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -8, 7, 0, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -9, 8, 0, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -10, 9, 0, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -11, 0, 1, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -12, 1, 1, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -13, 2, 1, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -14, 3, 1, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -15, 4, 1, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -16, 5, 1, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -17, 6, 1, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -31, 0, 3, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -30, 9, 2, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -29, 8, 2, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -28, 7, 2, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -27, 6, 2, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -26, 5, 2, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -33, 2, 3, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -25, 4, 2, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -23, 2, 2, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -22, 1, 2, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -21, 0, 2, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -20, 9, 1, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -19, 8, 1, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -18, 7, 1, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -24, 3, 2, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -138, 7, 13, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -68, 7, 6, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -70, 9, 6, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -106, 5, 10, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -107, 6, 10, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -108, 7, 10, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -109, 8, 10, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -110, 9, 10, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -111, 0, 11, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -112, 1, 11, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -113, 2, 11, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -114, 3, 11, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -115, 4, 11, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -116, 5, 11, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -117, 6, 11, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -118, 7, 11, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -119, 8, 11, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -120, 9, 11, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -121, 0, 12, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -122, 1, 12, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -136, 5, 13, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -135, 4, 13, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -134, 3, 13, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -133, 2, 13, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -132, 1, 13, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -131, 0, 13, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -105, 4, 10, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -130, 9, 12, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -274, 3, 4, -3 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -127, 6, 12, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -126, 5, 12, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -125, 4, 12, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -124, 3, 12, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -123, 2, 12, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -129, 8, 12, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -69, 8, 6, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -104, 3, 10, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -102, 1, 10, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -71, 0, 7, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -72, 1, 7, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -73, 2, 7, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -74, 3, 7, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -75, 4, 7, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -76, 5, 7, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -77, 6, 7, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -78, 7, 7, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -79, 8, 7, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -80, 9, 7, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -81, 0, 8, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -82, 1, 8, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -83, 2, 8, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -84, 3, 8, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -85, 4, 8, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -86, 5, 8, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -87, 6, 8, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -101, 0, 10, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -100, 9, 9, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -99, 8, 9, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -98, 7, 9, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -97, 6, 9, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -96, 5, 9, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -103, 2, 10, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -95, 4, 9, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -93, 2, 9, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -92, 1, 9, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -91, 0, 9, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -90, 9, 8, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -89, 8, 8, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -88, 7, 8, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -94, 3, 9, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -275, 4, 4, -3 });

            migrationBuilder.InsertData(
                table: "ActorMovie",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[] { -7, -7, -4 });

            migrationBuilder.InsertData(
                table: "ActorMovie",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[] { -22, -21, -11 });

            migrationBuilder.InsertData(
                table: "ActorMovie",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[] { -21, -20, -11 });

            migrationBuilder.InsertData(
                table: "ActorMovie",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[] { -10, -10, -5 });

            migrationBuilder.InsertData(
                table: "ActorMovie",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[] { -20, -19, -10 });

            migrationBuilder.InsertData(
                table: "ActorMovie",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[] { -19, -18, -10 });

            migrationBuilder.InsertData(
                table: "ActorMovie",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[] { -18, -17, -9 });

            migrationBuilder.InsertData(
                table: "ActorMovie",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[] { -9, -9, -5 });

            migrationBuilder.InsertData(
                table: "ActorMovie",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[] { -16, -15, -8 });

            migrationBuilder.InsertData(
                table: "ActorMovie",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[] { -15, -14, -8 });

            migrationBuilder.InsertData(
                table: "ActorMovie",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[] { -12, -12, -6 });

            migrationBuilder.InsertData(
                table: "ActorMovie",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[] { -11, -11, -6 });

            migrationBuilder.InsertData(
                table: "ActorMovie",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[] { -8, -8, -4 });

            migrationBuilder.InsertData(
                table: "ActorMovie",
                columns: new[] { "Id", "ActorId", "MovieId" },
                values: new object[] { -17, -16, -9 });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -199, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -143, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -101, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -148, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -100, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -147, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -99, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -146, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -200, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -144, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -98, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -144, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -97, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -143, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -94, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -138, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -197, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -141, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -196, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -140, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -96, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -140, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -195, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -139, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -95, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -139, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -201, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -148, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -198, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -142, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -102, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -149, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -207, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -158, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -202, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -152, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -216, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -168, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -215, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -167, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -214, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -166, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -213, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -164, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -212, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -163, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -211, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -162, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -103, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -150, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -210, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -161, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -208, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -159, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -194, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -137, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -206, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -156, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -205, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -155, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -204, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -154, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -203, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -153, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -209, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -160, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -193, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -135, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -189, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -130, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -93, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -134, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -82, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -122, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -81, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -121, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -182, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -120, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -80, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -120, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -181, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -119, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -180, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -118, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -183, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -122, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -79, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -118, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -78, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -117, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -178, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -113, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -177, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -110, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -176, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -109, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -77, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -109, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -76, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -108, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -179, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -117, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -83, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -123, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -184, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -123, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -84, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -124, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -191, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -133, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -92, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -132, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -190, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -131, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -91, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -131, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -217, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -169, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -90, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -130, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -188, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -129, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -89, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -129, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -88, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -128, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -187, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -127, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -87, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -127, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -186, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -126, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -86, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -126, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -85, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -125, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -185, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -124, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -192, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -134, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -218, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -171, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -225, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -186, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -220, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -175, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -280, true, 0.0, 14.0, -5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -253, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -279, true, 0.0, 14.0, -5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -251, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -269, true, 0.0, 8.0, -4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -251, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -268, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -250, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -267, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -249, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -266, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -248, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -281, true, 0.0, 14.0, -5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -256, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -265, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -247, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -263, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -242, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -262, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -240, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -261, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -237, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -260, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -236, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -259, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -235, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -258, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -234, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -264, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -246, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -257, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -233, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -270, true, 0.0, 8.0, -4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -257, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -283, true, 0.0, 14.0, -5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -258, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -278, true, 0.0, 8.0, -4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -273, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -277, true, 0.0, 8.0, -4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -272, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -289, true, 0.0, 14.0, -5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -270, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -288, true, 0.0, 14.0, -5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -269, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -287, true, 0.0, 14.0, -5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -268, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -276, true, 0.0, 8.0, -4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -268, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -282, true, 0.0, 14.0, -5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -257, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -275, true, 0.0, 8.0, -4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -266, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -273, true, 0.0, 8.0, -4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -264, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -286, true, 0.0, 14.0, -5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -263, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -272, true, 0.0, 8.0, -4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -263, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -285, true, 0.0, 14.0, -5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -262, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -284, true, 0.0, 14.0, -5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -259, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -271, true, 0.0, 8.0, -4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -259, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -274, true, 0.0, 8.0, -4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -265, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -256, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -232, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -255, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -231, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -254, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -230, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -234, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -203, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -233, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -202, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -232, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -201, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -231, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -199, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -230, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -194, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -229, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -192, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -235, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -204, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -228, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -191, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -226, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -187, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -175, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -107, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -224, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -185, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -223, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -184, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -222, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -179, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -221, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -176, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -227, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -190, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -236, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -205, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -237, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -206, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -238, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -207, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -253, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -229, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -252, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -228, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -251, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -224, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -250, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -222, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -249, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -221, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -248, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -219, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -247, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -218, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -246, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -217, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -245, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -216, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -244, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -215, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -243, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -214, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -242, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -211, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -241, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -210, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -240, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -209, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -239, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -208, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -219, true, 0.0, 9.0, -3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -172, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -75, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -107, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -71, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -103, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -74, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -106, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -25, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -42, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -24, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -41, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -129, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -40, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -23, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -40, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -128, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -39, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -22, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -39, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -130, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -42, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -127, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -38, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -126, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -36, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -20, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -36, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -125, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -35, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -19, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -35, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -124, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -34, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -123, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -31, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -21, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -37, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -18, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -31, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -26, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -43, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -27, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -45, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -35, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -54, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -137, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -53, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -34, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -53, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -33, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -52, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -136, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -51, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -32, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -51, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -131, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -44, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -135, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -50, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -30, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -49, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -134, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -48, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -29, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -48, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -133, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -47, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -132, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -46, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -28, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -46, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -31, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -50, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -122, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -29, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -121, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -28, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -120, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -27, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -6, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -10, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -111, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -9, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -5, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -9, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -110, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -8, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -4, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -8, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -109, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -7, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -7, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -11, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -3, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -7, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -107, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -4, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -106, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -3, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -2, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -3, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -105, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -2, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -104, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -1, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -1, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -108, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -5, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -112, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -11, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -8, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -12, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -113, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -14, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -17, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -27, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -119, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -26, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -16, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -26, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -15, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -24, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -14, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -23, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -118, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -22, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -13, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -21, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -117, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -19, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -12, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -19, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -116, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -18, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -11, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -18, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -10, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -17, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -115, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -16, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -9, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -16, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -114, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -15, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -138, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -54, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -139, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -55, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -140, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -56, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -36, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -57, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -64, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -93, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -163, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -92, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -162, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -91, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -63, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -91, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -62, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -90, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -161, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -89, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -164, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -93, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -160, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -88, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -61, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -87, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -158, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -86, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -157, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -85, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -60, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -85, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -59, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -84, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -156, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -83, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -159, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -87, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -65, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -94, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -66, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -95, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -67, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -96, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -173, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -105, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -73, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -105, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -72, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -104, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -172, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -103, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -290, true, 0.0, 14.0, -5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -274, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -171, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -102, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -170, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -101, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -70, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -101, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -169, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -100, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -69, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -100, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -168, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -99, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -167, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -98, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -68, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -98, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -166, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -97, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -165, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -96, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -58, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -83, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -174, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -106, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -57, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -82, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -56, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -81, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -44, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -65, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -146, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -64, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -43, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -64, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -145, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -63, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -42, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -63, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -41, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -62, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -45, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -66, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -144, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -61, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -39, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -60, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -143, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -59, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -38, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -59, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -142, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -58, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -37, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -58, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -141, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -57, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -40, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -61, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -46, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -67, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -47, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -68, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -48, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -69, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -55, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -80, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -154, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -79, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -54, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -78, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -153, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -77, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -53, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -77, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -152, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -76, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -52, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -76, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -151, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -75, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -150, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -73, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -51, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -73, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -149, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -72, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -50, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -71, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -148, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -70, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -49, true, 0.0, 10.0, -1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -70, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -147, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -69, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -155, true, 0.0, 12.0, -2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -81, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "PointsPrice", "Price", "ReproductionId", "ReserveTime", "SeatId", "UserId" },
                values: new object[] { -291, true, 0.0, 14.0, -5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), -275, null });

            migrationBuilder.CreateIndex(
                name: "IX_ActorMovie_ActorId",
                table: "ActorMovie",
                column: "ActorId");

            migrationBuilder.CreateIndex(
                name: "IX_ActorMovie_MovieId",
                table: "ActorMovie",
                column: "MovieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorMovie");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "Actor");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -271);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -267);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -261);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -260);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -255);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -254);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -252);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -245);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -244);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -243);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -241);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -239);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -238);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -227);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -226);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -225);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -223);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -220);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -213);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -212);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -200);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -198);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -197);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -196);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -195);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -193);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -189);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -188);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -183);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -182);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -181);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -180);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -178);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -177);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -174);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -173);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -170);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -165);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -157);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -151);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -145);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -136);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -116);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -115);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -114);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -112);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -111);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -74);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -33);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -32);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -30);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -25);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -20);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -291);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -290);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -289);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -288);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -287);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -286);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -285);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -284);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -283);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -282);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -281);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -280);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -279);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -278);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -277);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -276);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -275);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -274);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -273);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -272);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -271);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -270);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -269);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -268);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -267);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -266);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -265);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -264);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -263);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -262);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -261);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -260);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -259);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -258);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -257);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -256);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -255);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -254);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -253);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -252);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -251);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -250);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -249);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -248);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -247);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -246);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -245);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -244);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -243);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -242);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -241);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -240);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -239);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -238);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -237);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -236);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -235);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -234);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -233);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -232);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -231);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -230);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -229);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -228);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -227);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -226);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -225);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -224);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -223);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -222);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -221);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -220);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -219);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -218);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -217);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -216);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -215);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -214);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -213);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -212);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -211);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -210);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -209);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -208);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -207);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -206);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -205);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -204);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -203);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -202);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -201);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -200);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -199);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -198);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -197);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -196);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -195);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -194);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -193);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -192);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -191);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -190);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -189);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -188);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -187);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -186);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -185);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -184);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -183);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -182);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -181);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -180);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -179);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -178);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -177);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -176);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -175);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -174);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -173);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -172);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -171);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -170);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -169);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -168);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -167);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -166);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -165);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -164);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -163);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -162);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -161);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -160);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -159);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -158);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -157);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -156);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -155);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -154);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -153);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -152);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -151);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -150);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -149);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -148);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -147);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -146);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -145);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -144);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -143);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -142);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -141);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -140);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -139);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -138);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -137);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -136);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -135);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -134);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -133);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -132);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -131);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -130);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -129);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -128);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -127);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -126);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -125);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -124);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -123);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -122);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -121);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -120);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -119);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -118);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -117);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -116);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -115);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -114);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -113);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -112);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -111);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -110);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -109);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -108);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -107);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -106);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -105);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -104);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -103);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -102);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -101);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -100);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -99);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -98);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -97);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -96);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -95);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -94);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -93);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -92);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -91);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -90);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -89);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -88);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -87);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -86);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -85);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -84);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -83);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -82);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -81);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -80);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -79);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -78);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -77);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -76);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -75);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -74);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -73);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -72);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -71);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -70);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -69);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -68);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -67);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -66);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -65);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -64);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -63);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -62);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -61);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -60);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -59);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -58);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -57);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -56);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -55);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -54);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -53);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -52);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -51);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -50);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -49);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -48);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -47);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -46);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -45);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -44);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -43);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -42);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -41);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -40);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -39);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -38);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -37);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -36);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -35);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -34);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -33);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -32);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -31);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -30);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -29);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -28);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -27);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -26);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -25);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -24);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -23);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -22);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -21);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -20);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -19);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -18);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -17);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -16);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -15);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Reproduction",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Reproduction",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Reproduction",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Reproduction",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Reproduction",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -275);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -274);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -273);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -272);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -270);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -269);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -268);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -266);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -265);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -264);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -263);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -262);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -259);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -258);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -257);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -256);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -253);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -251);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -250);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -249);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -248);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -247);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -246);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -242);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -240);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -237);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -236);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -235);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -234);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -233);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -232);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -231);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -230);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -229);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -228);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -224);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -222);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -221);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -219);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -218);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -217);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -216);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -215);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -214);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -211);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -210);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -209);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -208);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -207);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -206);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -205);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -204);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -203);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -202);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -201);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -199);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -194);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -192);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -191);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -190);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -187);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -186);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -185);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -184);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -179);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -176);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -175);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -172);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -171);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -169);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -168);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -167);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -166);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -164);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -163);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -162);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -161);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -160);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -159);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -158);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -156);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -155);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -154);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -153);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -152);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -150);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -149);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -148);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -147);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -146);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -144);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -143);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -142);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -141);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -140);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -139);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -138);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -137);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -135);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -134);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -133);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -132);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -131);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -130);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -129);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -128);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -127);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -126);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -125);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -124);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -123);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -122);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -121);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -120);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -119);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -118);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -117);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -113);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -110);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -109);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -108);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -107);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -106);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -105);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -104);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -103);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -102);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -101);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -100);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -99);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -98);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -97);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -96);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -95);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -94);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -93);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -92);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -91);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -90);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -89);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -88);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -87);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -86);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -85);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -84);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -83);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -82);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -81);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -80);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -79);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -78);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -77);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -76);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -75);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -73);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -72);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -71);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -70);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -69);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -68);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -67);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -66);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -65);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -64);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -63);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -62);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -61);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -60);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -59);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -58);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -57);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -56);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -55);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -54);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -53);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -52);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -51);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -50);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -49);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -48);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -47);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -46);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -45);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -44);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -43);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -42);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -41);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -40);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -39);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -38);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -37);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -36);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -35);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -34);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -31);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -29);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -28);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -27);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -26);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -24);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -23);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -22);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -21);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -19);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -18);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -17);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -16);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -15);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Theater",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Theater",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Theater",
                keyColumn: "Id",
                keyValue: -1);

            migrationBuilder.DropColumn(
                name: "Confirmed",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "PointsPrice",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "ReserveTime",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "Columns",
                table: "Theater");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Reproduction");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Display",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Movie");

            migrationBuilder.RenameColumn(
                name: "Rows",
                table: "Theater",
                newName: "Capacity");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "Director", "Duration", "MovieName", "Score" },
                values: new object[] { "Alain Serdán", 130, "Dos es mejor que uno", 0.0 });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "Director", "Duration", "GenreId", "MovieName", "Score" },
                values: new object[] { "Alfredo Jul", 113, -1, "Donde cayó la tiza", 9.0 });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Director", "Duration", "GenreId", "MovieName", "Score" },
                values: new object[] { "Pedro Pérez", 134, -1, "Los 3 de la loma", 7.8000001907348633 });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cineplus.Data.Migrations
{
    public partial class SeededTheatersSeatsReproductions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Reproduction",
                columns: new[] { "Id", "MovieId", "StartTime", "TheaterId" },
                values: new object[] { -1, -1, new DateTime(2021, 5, 26, 21, 43, 29, 653, DateTimeKind.Local).AddTicks(7261), -1 });

            migrationBuilder.InsertData(
                table: "Reproduction",
                columns: new[] { "Id", "MovieId", "StartTime", "TheaterId" },
                values: new object[] { -2, -1, new DateTime(2021, 5, 26, 21, 43, 29, 659, DateTimeKind.Local).AddTicks(2756), -1 });

            migrationBuilder.InsertData(
                table: "Reproduction",
                columns: new[] { "Id", "MovieId", "StartTime", "TheaterId" },
                values: new object[] { -3, -1, new DateTime(2021, 5, 26, 21, 43, 29, 659, DateTimeKind.Local).AddTicks(2815), -2 });

            migrationBuilder.InsertData(
                table: "Reproduction",
                columns: new[] { "Id", "MovieId", "StartTime", "TheaterId" },
                values: new object[] { -5, -1, new DateTime(2021, 5, 26, 21, 43, 29, 659, DateTimeKind.Local).AddTicks(2829), -3 });

            migrationBuilder.InsertData(
                table: "Reproduction",
                columns: new[] { "Id", "MovieId", "StartTime", "TheaterId" },
                values: new object[] { -4, -1, new DateTime(2021, 5, 26, 21, 43, 29, 659, DateTimeKind.Local).AddTicks(2823), -3 });

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
                values: new object[] { -183, 2, 3, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -182, 1, 3, -2 });

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
                values: new object[] { -175, 4, 2, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -187, 6, 3, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -188, 7, 3, -2 });

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
                values: new object[] { -204, 3, 5, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -203, 2, 5, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -202, 1, 5, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -201, 0, 5, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -200, 9, 4, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -199, 8, 4, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -174, 3, 2, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -198, 7, 4, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -196, 5, 4, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -195, 4, 4, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -194, 3, 4, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -193, 2, 4, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -192, 1, 4, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -191, 0, 4, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -197, 6, 4, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -173, 2, 2, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -171, 0, 2, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -205, 4, 5, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -141, 0, 14, -1 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -142, 1, 14, -1 });

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
                values: new object[] { -172, 1, 2, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -155, 4, 0, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -157, 6, 0, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -158, 7, 0, -2 });

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
                values: new object[] { -156, 5, 0, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -206, 5, 5, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -208, 7, 5, -2 });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "Column", "Row", "TheaterId" },
                values: new object[] { -140, 9, 13, -1 });

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
                values: new object[] { -218, 7, 6, -2 });

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
                values: new object[] { -138, 7, 13, -1 });

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
                values: new object[] { -274, 3, 4, -3 });

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
                values: new object[] { -128, 7, 12, -1 });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                keyValue: -271);

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
                keyValue: -267);

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
                keyValue: -261);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -260);

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
                keyValue: -255);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -254);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -253);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -252);

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
                keyValue: -242);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -241);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -240);

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
                keyValue: -224);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -223);

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
                keyValue: -220);

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
                keyValue: -213);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -212);

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
                keyValue: -200);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -199);

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
                keyValue: -194);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -193);

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
                keyValue: -189);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -188);

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
                keyValue: -179);

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
                keyValue: -176);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -175);

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
                keyValue: -172);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -171);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -170);

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
                keyValue: -165);

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
                keyValue: -157);

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
                keyValue: -151);

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
                keyValue: -145);

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
                keyValue: -136);

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
                keyValue: -113);

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
                keyValue: -74);

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
                keyValue: -33);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -32);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -31);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: -30);

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
                keyValue: -25);

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
                keyValue: -20);

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
                keyValue: -13);

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
                keyValue: -6);

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
        }
    }
}

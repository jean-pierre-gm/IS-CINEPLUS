using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cineplus.Data.Migrations
{
    public partial class Tickets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Confirmed",
                table: "Ticket",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Ticket",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Reproduction",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Reproduction",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "Price", "StartTime" },
                values: new object[] { 14.0, new DateTime(2021, 6, 6, 22, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reproduction",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "Price", "StartTime" },
                values: new object[] { 8.0, new DateTime(2021, 6, 6, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reproduction",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "Price", "StartTime" },
                values: new object[] { 9.0, new DateTime(2021, 6, 6, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reproduction",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "Price", "StartTime" },
                values: new object[] { 12.0, new DateTime(2021, 6, 6, 22, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Reproduction",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Price", "StartTime" },
                values: new object[] { 10.0, new DateTime(2021, 6, 6, 18, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -200, true, 12.0, -2, -144, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -199, true, 12.0, -2, -143, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -198, true, 12.0, -2, -142, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -197, true, 12.0, -2, -141, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -196, true, 12.0, -2, -140, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -195, true, 12.0, -2, -139, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -201, true, 12.0, -2, -148, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -194, true, 12.0, -2, -137, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -192, true, 12.0, -2, -134, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -191, true, 12.0, -2, -133, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -190, true, 12.0, -2, -131, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -189, true, 12.0, -2, -130, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -188, true, 12.0, -2, -129, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -187, true, 12.0, -2, -127, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -193, true, 12.0, -2, -135, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -186, true, 12.0, -2, -126, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -202, true, 9.0, -3, -152, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -204, true, 9.0, -3, -154, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -218, true, 9.0, -3, -171, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -217, true, 9.0, -3, -169, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -216, true, 9.0, -3, -168, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -215, true, 9.0, -3, -167, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -214, true, 9.0, -3, -166, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -213, true, 9.0, -3, -164, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -203, true, 9.0, -3, -153, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -212, true, 9.0, -3, -163, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -210, true, 9.0, -3, -161, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -209, true, 9.0, -3, -160, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -208, true, 9.0, -3, -159, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -207, true, 9.0, -3, -158, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -206, true, 9.0, -3, -156, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -205, true, 9.0, -3, -155, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -211, true, 9.0, -3, -162, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -150, true, 12.0, -2, -73, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -185, true, 12.0, -2, -124, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -183, true, 12.0, -2, -122, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -164, true, 12.0, -2, -93, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -163, true, 12.0, -2, -92, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -162, true, 12.0, -2, -91, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -161, true, 12.0, -2, -89, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -160, true, 12.0, -2, -88, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -159, true, 12.0, -2, -87, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -165, true, 12.0, -2, -96, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -158, true, 12.0, -2, -86, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -156, true, 12.0, -2, -83, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -155, true, 12.0, -2, -81, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -154, true, 12.0, -2, -79, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -153, true, 12.0, -2, -77, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -152, true, 12.0, -2, -76, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -151, true, 12.0, -2, -75, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -157, true, 12.0, -2, -85, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -219, true, 9.0, -3, -172, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -166, true, 12.0, -2, -97, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -168, true, 12.0, -2, -99, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -182, true, 12.0, -2, -120, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -181, true, 12.0, -2, -119, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -180, true, 12.0, -2, -118, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -179, true, 12.0, -2, -117, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -178, true, 12.0, -2, -113, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -177, true, 12.0, -2, -110, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -167, true, 12.0, -2, -98, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -176, true, 12.0, -2, -109, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -174, true, 12.0, -2, -106, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -173, true, 12.0, -2, -105, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -172, true, 12.0, -2, -103, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -171, true, 12.0, -2, -102, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -170, true, 12.0, -2, -101, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -169, true, 12.0, -2, -100, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -175, true, 12.0, -2, -107, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -184, true, 12.0, -2, -123, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -221, true, 9.0, -3, -176, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -149, true, 12.0, -2, -72, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -273, true, 8.0, -4, -264, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -272, true, 8.0, -4, -263, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -271, true, 8.0, -4, -259, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -270, true, 8.0, -4, -257, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -269, true, 8.0, -4, -251, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -268, true, 9.0, -3, -250, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -274, true, 8.0, -4, -265, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -267, true, 9.0, -3, -249, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -265, true, 9.0, -3, -247, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -264, true, 9.0, -3, -246, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -263, true, 9.0, -3, -242, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -262, true, 9.0, -3, -240, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -261, true, 9.0, -3, -237, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -260, true, 9.0, -3, -236, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -266, true, 9.0, -3, -248, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -259, true, 9.0, -3, -235, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -275, true, 8.0, -4, -266, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -277, true, 8.0, -4, -272, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -291, true, 14.0, -5, -275, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -290, true, 14.0, -5, -274, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -289, true, 14.0, -5, -270, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -288, true, 14.0, -5, -269, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -287, true, 14.0, -5, -268, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -286, true, 14.0, -5, -263, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -276, true, 8.0, -4, -268, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -285, true, 14.0, -5, -262, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -283, true, 14.0, -5, -258, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -282, true, 14.0, -5, -257, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -281, true, 14.0, -5, -256, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -280, true, 14.0, -5, -253, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -279, true, 14.0, -5, -251, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -278, true, 8.0, -4, -273, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -284, true, 14.0, -5, -259, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -258, true, 9.0, -3, -234, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -257, true, 9.0, -3, -233, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -256, true, 9.0, -3, -232, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -236, true, 9.0, -3, -205, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -235, true, 9.0, -3, -204, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -234, true, 9.0, -3, -203, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -233, true, 9.0, -3, -202, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -232, true, 9.0, -3, -201, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -231, true, 9.0, -3, -199, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -237, true, 9.0, -3, -206, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -230, true, 9.0, -3, -194, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -228, true, 9.0, -3, -191, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -227, true, 9.0, -3, -190, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -226, true, 9.0, -3, -187, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -225, true, 9.0, -3, -186, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -224, true, 9.0, -3, -185, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -223, true, 9.0, -3, -184, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -229, true, 9.0, -3, -192, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -238, true, 9.0, -3, -207, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -239, true, 9.0, -3, -208, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -240, true, 9.0, -3, -209, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -255, true, 9.0, -3, -231, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -254, true, 9.0, -3, -230, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -253, true, 9.0, -3, -229, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -252, true, 9.0, -3, -228, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -251, true, 9.0, -3, -224, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -250, true, 9.0, -3, -222, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -249, true, 9.0, -3, -221, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -248, true, 9.0, -3, -219, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -247, true, 9.0, -3, -218, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -246, true, 9.0, -3, -217, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -245, true, 9.0, -3, -216, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -244, true, 9.0, -3, -215, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -243, true, 9.0, -3, -214, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -242, true, 9.0, -3, -211, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -241, true, 9.0, -3, -210, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -220, true, 9.0, -3, -175, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -222, true, 9.0, -3, -179, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -148, true, 12.0, -2, -70, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -146, true, 12.0, -2, -64, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -52, true, 10.0, -1, -76, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -51, true, 10.0, -1, -73, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -50, true, 10.0, -1, -71, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -49, true, 10.0, -1, -70, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -48, true, 10.0, -1, -69, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -47, true, 10.0, -1, -68, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -53, true, 10.0, -1, -77, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -46, true, 10.0, -1, -67, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -44, true, 10.0, -1, -65, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -43, true, 10.0, -1, -64, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -42, true, 10.0, -1, -63, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -41, true, 10.0, -1, -62, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -40, true, 10.0, -1, -61, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -39, true, 10.0, -1, -60, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -45, true, 10.0, -1, -66, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -54, true, 10.0, -1, -78, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -55, true, 10.0, -1, -80, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -56, true, 10.0, -1, -81, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -71, true, 10.0, -1, -103, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -70, true, 10.0, -1, -101, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -69, true, 10.0, -1, -100, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -68, true, 10.0, -1, -98, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -67, true, 10.0, -1, -96, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -66, true, 10.0, -1, -95, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -65, true, 10.0, -1, -94, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -64, true, 10.0, -1, -93, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -63, true, 10.0, -1, -91, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -62, true, 10.0, -1, -90, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -61, true, 10.0, -1, -87, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -60, true, 10.0, -1, -85, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -59, true, 10.0, -1, -84, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -58, true, 10.0, -1, -83, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -57, true, 10.0, -1, -82, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -38, true, 10.0, -1, -59, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -72, true, 10.0, -1, -104, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -37, true, 10.0, -1, -58, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -35, true, 10.0, -1, -54, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -15, true, 10.0, -1, -24, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -14, true, 10.0, -1, -23, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -13, true, 10.0, -1, -21, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -12, true, 10.0, -1, -19, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -11, true, 10.0, -1, -18, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -10, true, 10.0, -1, -17, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -16, true, 10.0, -1, -26, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -9, true, 10.0, -1, -16, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -7, true, 10.0, -1, -11, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -6, true, 10.0, -1, -10, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -5, true, 10.0, -1, -9, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -4, true, 10.0, -1, -8, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -3, true, 10.0, -1, -7, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -2, true, 10.0, -1, -3, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -8, true, 10.0, -1, -12, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -17, true, 10.0, -1, -27, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -18, true, 10.0, -1, -31, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -19, true, 10.0, -1, -35, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -34, true, 10.0, -1, -53, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -33, true, 10.0, -1, -52, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -32, true, 10.0, -1, -51, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -31, true, 10.0, -1, -50, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -30, true, 10.0, -1, -49, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -29, true, 10.0, -1, -48, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -28, true, 10.0, -1, -46, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -27, true, 10.0, -1, -45, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -26, true, 10.0, -1, -43, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -25, true, 10.0, -1, -42, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -24, true, 10.0, -1, -41, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -23, true, 10.0, -1, -40, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -22, true, 10.0, -1, -39, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -21, true, 10.0, -1, -37, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -20, true, 10.0, -1, -36, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -36, true, 10.0, -1, -57, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -147, true, 12.0, -2, -69, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -73, true, 10.0, -1, -105, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -75, true, 10.0, -1, -107, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -126, true, 12.0, -2, -36, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -125, true, 12.0, -2, -35, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -124, true, 12.0, -2, -34, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -123, true, 12.0, -2, -31, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -122, true, 12.0, -2, -29, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -121, true, 12.0, -2, -28, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -127, true, 12.0, -2, -38, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -120, true, 12.0, -2, -27, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -118, true, 12.0, -2, -22, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -117, true, 12.0, -2, -19, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -116, true, 12.0, -2, -18, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -115, true, 12.0, -2, -16, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -114, true, 12.0, -2, -15, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -113, true, 12.0, -2, -14, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -119, true, 12.0, -2, -26, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -128, true, 12.0, -2, -39, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -129, true, 12.0, -2, -40, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -130, true, 12.0, -2, -42, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -145, true, 12.0, -2, -63, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -144, true, 12.0, -2, -61, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -143, true, 12.0, -2, -59, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -142, true, 12.0, -2, -58, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -141, true, 12.0, -2, -57, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -140, true, 12.0, -2, -56, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -139, true, 12.0, -2, -55, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -138, true, 12.0, -2, -54, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -137, true, 12.0, -2, -53, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -136, true, 12.0, -2, -51, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -135, true, 12.0, -2, -50, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -134, true, 12.0, -2, -48, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -133, true, 12.0, -2, -47, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -132, true, 12.0, -2, -46, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -131, true, 12.0, -2, -44, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -112, true, 12.0, -2, -11, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -74, true, 10.0, -1, -106, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -111, true, 12.0, -2, -9, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -109, true, 12.0, -2, -7, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -89, true, 10.0, -1, -129, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -88, true, 10.0, -1, -128, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -87, true, 10.0, -1, -127, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -86, true, 10.0, -1, -126, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -85, true, 10.0, -1, -125, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -84, true, 10.0, -1, -124, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -90, true, 10.0, -1, -130, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -83, true, 10.0, -1, -123, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -81, true, 10.0, -1, -121, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -80, true, 10.0, -1, -120, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -79, true, 10.0, -1, -118, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -78, true, 10.0, -1, -117, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -77, true, 10.0, -1, -109, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -76, true, 10.0, -1, -108, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -82, true, 10.0, -1, -122, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -91, true, 10.0, -1, -131, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -92, true, 10.0, -1, -132, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -93, true, 10.0, -1, -134, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -108, true, 12.0, -2, -5, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -107, true, 12.0, -2, -4, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -106, true, 12.0, -2, -3, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -105, true, 12.0, -2, -2, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -104, true, 12.0, -2, -1, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -103, true, 10.0, -1, -150, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -102, true, 10.0, -1, -149, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -101, true, 10.0, -1, -148, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -100, true, 10.0, -1, -147, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -99, true, 10.0, -1, -146, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -98, true, 10.0, -1, -144, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -97, true, 10.0, -1, -143, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -96, true, 10.0, -1, -140, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -95, true, 10.0, -1, -139, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -94, true, 10.0, -1, -138, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -110, true, 12.0, -2, -8, null });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Confirmed", "Price", "ReproductionId", "SeatId", "UserId" },
                values: new object[] { -1, true, 10.0, -1, -1, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "Confirmed",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Reproduction");

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
    }
}

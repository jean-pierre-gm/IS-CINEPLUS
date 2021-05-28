using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cineplus.Data.Migrations
{
    public partial class Price : Migration
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
                values: new object[] { 14.0, new DateTime(2021, 5, 28, 16, 58, 44, 544, DateTimeKind.Local).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "Reproduction",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "Price", "StartTime" },
                values: new object[] { 8.0, new DateTime(2021, 5, 28, 16, 58, 44, 544, DateTimeKind.Local).AddTicks(4558) });

            migrationBuilder.UpdateData(
                table: "Reproduction",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "Price", "StartTime" },
                values: new object[] { 9.0, new DateTime(2021, 5, 28, 16, 58, 44, 544, DateTimeKind.Local).AddTicks(4551) });

            migrationBuilder.UpdateData(
                table: "Reproduction",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "Price", "StartTime" },
                values: new object[] { 12.0, new DateTime(2021, 5, 28, 16, 58, 44, 544, DateTimeKind.Local).AddTicks(4505) });

            migrationBuilder.UpdateData(
                table: "Reproduction",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Price", "StartTime" },
                values: new object[] { 10.0, new DateTime(2021, 5, 28, 16, 58, 44, 540, DateTimeKind.Local).AddTicks(7858) });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -291,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 14.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -290,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 14.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -289,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 14.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -288,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 14.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -287,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 14.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -286,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 14.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -285,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 14.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -284,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 14.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -283,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 14.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -282,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 14.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -281,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 14.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -280,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 14.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -279,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 14.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -278,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 8.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -277,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 8.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -276,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 8.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -275,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 8.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -274,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 8.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -273,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 8.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -272,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 8.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -271,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 8.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -270,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 8.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -269,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 8.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -268,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -267,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -266,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -265,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -264,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -263,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -262,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -261,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -260,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -259,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -258,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -257,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -256,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -255,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -254,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -253,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -252,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -251,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -250,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -249,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -248,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -247,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -246,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -245,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -244,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -243,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -242,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -241,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -240,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -239,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -238,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -237,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -236,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -235,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -234,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -233,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -232,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -231,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -230,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -229,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -228,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -227,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -226,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -225,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -224,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -223,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -222,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -221,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -220,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -219,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -218,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -217,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -216,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -215,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -214,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -213,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -212,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -211,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -210,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -209,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -208,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -207,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -206,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -205,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -204,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -203,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -202,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 9.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -201,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -200,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -199,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -198,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -197,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -196,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -195,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -194,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -193,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -192,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -191,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -190,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -189,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -188,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -187,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -186,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -185,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -184,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -183,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -182,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -181,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -180,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -179,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -178,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -177,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -176,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -175,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -174,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -173,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -172,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -171,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -170,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -169,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -168,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -167,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -166,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -165,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -164,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -163,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -162,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -161,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -160,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -159,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -158,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -157,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -156,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -155,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -154,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -153,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -152,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -151,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -150,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -149,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -148,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -147,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -146,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -145,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -144,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -143,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -142,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -141,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -140,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -139,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -138,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -137,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -136,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -135,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -134,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -133,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -132,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -131,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -130,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -129,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -128,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -127,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -126,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -125,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -124,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -123,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -122,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -121,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -120,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -119,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -118,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -117,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -116,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -115,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -114,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -113,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -112,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -111,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -110,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -109,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -108,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -107,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -106,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -105,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -104,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 12.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -103,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -102,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -101,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -100,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -99,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -98,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -97,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -96,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -95,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -94,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -93,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -92,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -91,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -90,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -89,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -88,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -87,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -86,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -85,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -84,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -83,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -82,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -81,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -80,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -79,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -78,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -77,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -76,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -75,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -74,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -73,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -72,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -71,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -70,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -69,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -68,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -67,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -66,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -65,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -64,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -63,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -62,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -61,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -60,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -59,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -58,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -57,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -56,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -55,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -54,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -53,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -52,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -51,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -50,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -49,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -48,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -47,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -46,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -45,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -44,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -43,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -42,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -41,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -40,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -39,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -38,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -37,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -36,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -35,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -34,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -33,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -32,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -31,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -30,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -29,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -28,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -27,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -26,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -25,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -24,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -23,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -22,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -21,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -20,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -19,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -18,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -17,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -16,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -15,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -14,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -13,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -12,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -11,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -10,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -9,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -8,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -7,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -6,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -5,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -4,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -3,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -2,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -1,
                columns: new[] { "Confirmed", "Price" },
                values: new object[] { true, 10.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                value: new DateTime(2021, 5, 28, 14, 27, 51, 300, DateTimeKind.Local).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "Reproduction",
                keyColumn: "Id",
                keyValue: -4,
                column: "StartTime",
                value: new DateTime(2021, 5, 28, 14, 27, 51, 300, DateTimeKind.Local).AddTicks(9086));

            migrationBuilder.UpdateData(
                table: "Reproduction",
                keyColumn: "Id",
                keyValue: -3,
                column: "StartTime",
                value: new DateTime(2021, 5, 28, 14, 27, 51, 300, DateTimeKind.Local).AddTicks(9077));

            migrationBuilder.UpdateData(
                table: "Reproduction",
                keyColumn: "Id",
                keyValue: -2,
                column: "StartTime",
                value: new DateTime(2021, 5, 28, 14, 27, 51, 300, DateTimeKind.Local).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "Reproduction",
                keyColumn: "Id",
                keyValue: -1,
                column: "StartTime",
                value: new DateTime(2021, 5, 28, 14, 27, 51, 295, DateTimeKind.Local).AddTicks(9158));
        }
    }
}

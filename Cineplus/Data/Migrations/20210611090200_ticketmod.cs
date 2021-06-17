using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cineplus.Data.Migrations
{
    public partial class ticketmod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Confirmed",
                table: "Ticket");

            migrationBuilder.AddColumn<Guid>(
                name: "Confirmation",
                table: "Ticket",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "DateDiscountId",
                table: "Ticket",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "OrderId",
                table: "Ticket",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "TicketId",
                table: "PersonalDiscount",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_DateDiscountId",
                table: "Ticket",
                column: "DateDiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalDiscount_TicketId",
                table: "PersonalDiscount",
                column: "TicketId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonalDiscount_Ticket_TicketId",
                table: "PersonalDiscount",
                column: "TicketId",
                principalTable: "Ticket",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_DateDiscount_DateDiscountId",
                table: "Ticket",
                column: "DateDiscountId",
                principalTable: "DateDiscount",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonalDiscount_Ticket_TicketId",
                table: "PersonalDiscount");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_DateDiscount_DateDiscountId",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_Ticket_DateDiscountId",
                table: "Ticket");

            migrationBuilder.DropIndex(
                name: "IX_PersonalDiscount_TicketId",
                table: "PersonalDiscount");

            migrationBuilder.DropColumn(
                name: "Confirmation",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "DateDiscountId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Ticket");

            migrationBuilder.DropColumn(
                name: "TicketId",
                table: "PersonalDiscount");

            migrationBuilder.AddColumn<bool>(
                name: "Confirmed",
                table: "Ticket",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -291,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -290,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -289,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -288,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -287,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -286,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -285,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -284,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -283,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -282,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -281,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -280,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -279,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -278,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -277,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -276,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -275,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -274,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -273,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -272,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -271,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -270,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -269,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -268,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -267,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -266,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -265,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -264,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -263,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -262,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -261,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -260,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -259,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -258,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -257,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -256,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -255,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -254,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -253,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -252,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -251,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -250,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -249,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -248,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -247,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -246,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -245,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -244,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -243,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -242,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -241,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -240,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -239,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -238,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -237,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -236,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -235,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -234,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -233,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -232,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -231,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -230,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -229,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -228,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -227,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -226,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -225,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -224,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -223,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -222,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -221,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -220,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -219,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -218,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -217,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -216,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -215,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -214,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -213,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -212,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -211,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -210,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -209,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -208,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -207,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -206,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -205,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -204,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -203,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -202,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -201,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -200,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -199,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -198,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -197,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -196,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -195,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -194,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -193,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -192,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -191,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -190,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -189,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -188,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -187,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -186,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -185,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -184,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -183,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -182,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -181,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -180,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -179,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -178,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -177,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -176,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -175,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -174,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -173,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -172,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -171,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -170,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -169,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -168,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -167,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -166,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -165,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -164,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -163,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -162,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -161,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -160,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -159,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -158,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -157,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -156,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -155,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -154,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -153,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -152,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -151,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -150,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -149,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -148,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -147,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -146,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -145,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -144,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -143,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -142,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -141,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -140,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -139,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -138,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -137,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -136,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -135,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -134,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -133,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -132,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -131,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -130,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -129,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -128,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -127,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -126,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -125,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -124,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -123,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -122,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -121,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -120,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -119,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -118,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -117,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -116,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -115,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -114,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -113,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -112,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -111,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -110,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -109,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -108,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -107,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -106,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -105,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -104,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -103,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -102,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -101,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -100,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -99,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -98,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -97,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -96,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -95,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -94,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -93,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -92,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -91,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -90,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -89,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -88,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -87,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -86,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -85,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -84,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -83,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -82,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -81,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -80,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -79,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -78,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -77,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -76,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -75,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -74,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -73,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -72,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -71,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -70,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -69,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -68,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -67,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -66,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -65,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -64,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -63,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -62,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -61,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -60,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -59,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -58,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -57,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -56,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -55,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -54,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -53,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -52,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -51,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -50,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -49,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -48,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -47,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -46,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -45,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -44,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -43,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -42,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -41,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -40,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -39,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -38,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -37,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -36,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -35,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -34,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -33,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -32,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -31,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -30,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -29,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -28,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -27,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -26,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -25,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -24,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -23,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -22,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -21,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -20,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -19,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -18,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -17,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -16,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -15,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -14,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -13,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -12,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -11,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -10,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -9,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -8,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -7,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -6,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -5,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -4,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -3,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -2,
                column: "Confirmed",
                value: true);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: -1,
                column: "Confirmed",
                value: true);
        }
    }
}

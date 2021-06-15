using Microsoft.EntityFrameworkCore.Migrations;

namespace Cineplus.Data.Migrations
{
    public partial class ManytoManyTicketsDiscounts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonalDiscount_Ticket_TicketId",
                table: "PersonalDiscount");

            migrationBuilder.DropIndex(
                name: "IX_PersonalDiscount_TicketId",
                table: "PersonalDiscount");

            migrationBuilder.DropColumn(
                name: "TicketId",
                table: "PersonalDiscount");

            migrationBuilder.CreateTable(
                name: "PersonalDiscountTicket",
                columns: table => new
                {
                    PersonalDiscountsId = table.Column<int>(type: "INTEGER", nullable: false),
                    TicketsId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalDiscountTicket", x => new { x.PersonalDiscountsId, x.TicketsId });
                    table.ForeignKey(
                        name: "FK_PersonalDiscountTicket_PersonalDiscount_PersonalDiscountsId",
                        column: x => x.PersonalDiscountsId,
                        principalTable: "PersonalDiscount",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonalDiscountTicket_Ticket_TicketsId",
                        column: x => x.TicketsId,
                        principalTable: "Ticket",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonalDiscountTicket_TicketsId",
                table: "PersonalDiscountTicket",
                column: "TicketsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonalDiscountTicket");

            migrationBuilder.AddColumn<int>(
                name: "TicketId",
                table: "PersonalDiscount",
                type: "INTEGER",
                nullable: true);

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
        }
    }
}

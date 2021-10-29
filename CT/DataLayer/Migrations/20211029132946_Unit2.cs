using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class Unit2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Concerts_ConcertId",
                table: "Ticket");

            migrationBuilder.DropTable(
                name: "BuyTicket");

            migrationBuilder.DropTable(
                name: "ReservedTicket");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ticket",
                table: "Ticket");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "Ticket",
                newName: "Tickets");

            migrationBuilder.RenameIndex(
                name: "IX_Ticket_ConcertId",
                table: "Tickets",
                newName: "IX_Tickets_ConcertId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tickets",
                table: "Tickets",
                column: "TicketID");

            migrationBuilder.CreateTable(
                name: "DeletedTickeds",
                columns: table => new
                {
                    DelTicketId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SingerDeletedConcert = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateConcert = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Sector = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeletedTickeds", x => x.DelTicketId);
                });

            migrationBuilder.CreateTable(
                name: "StatusTickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameStatus = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusTickets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InfoAboutDeleteTickets",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    DeletedTicketId = table.Column<int>(type: "int", nullable: false),
                    StatusTickedId = table.Column<int>(type: "int", nullable: false),
                    StatusTicketId = table.Column<int>(type: "int", nullable: true),
                    NumTicket = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfoAboutDeleteTickets", x => new { x.UserId, x.DeletedTicketId, x.StatusTickedId });
                    table.ForeignKey(
                        name: "FK_InfoAboutDeleteTickets_DeletedTickeds_DeletedTicketId",
                        column: x => x.DeletedTicketId,
                        principalTable: "DeletedTickeds",
                        principalColumn: "DelTicketId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InfoAboutDeleteTickets_StatusTickets_StatusTicketId",
                        column: x => x.StatusTicketId,
                        principalTable: "StatusTickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InfoAboutDeleteTickets_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InfoAboutTickets",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TicketId = table.Column<int>(type: "int", nullable: false),
                    StatusTickedId = table.Column<int>(type: "int", nullable: false),
                    StatusTicketId = table.Column<int>(type: "int", nullable: true),
                    NumTicket = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfoAboutTickets", x => new { x.UserId, x.TicketId, x.StatusTickedId });
                    table.ForeignKey(
                        name: "FK_InfoAboutTickets_StatusTickets_StatusTicketId",
                        column: x => x.StatusTicketId,
                        principalTable: "StatusTickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InfoAboutTickets_Tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Tickets",
                        principalColumn: "TicketID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InfoAboutTickets_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InfoAboutDeleteTickets_DeletedTicketId",
                table: "InfoAboutDeleteTickets",
                column: "DeletedTicketId");

            migrationBuilder.CreateIndex(
                name: "IX_InfoAboutDeleteTickets_StatusTicketId",
                table: "InfoAboutDeleteTickets",
                column: "StatusTicketId");

            migrationBuilder.CreateIndex(
                name: "IX_InfoAboutTickets_StatusTicketId",
                table: "InfoAboutTickets",
                column: "StatusTicketId");

            migrationBuilder.CreateIndex(
                name: "IX_InfoAboutTickets_TicketId",
                table: "InfoAboutTickets",
                column: "TicketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Concerts_ConcertId",
                table: "Tickets",
                column: "ConcertId",
                principalTable: "Concerts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Concerts_ConcertId",
                table: "Tickets");

            migrationBuilder.DropTable(
                name: "InfoAboutDeleteTickets");

            migrationBuilder.DropTable(
                name: "InfoAboutTickets");

            migrationBuilder.DropTable(
                name: "DeletedTickeds");

            migrationBuilder.DropTable(
                name: "StatusTickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tickets",
                table: "Tickets");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "Tickets",
                newName: "Ticket");

            migrationBuilder.RenameIndex(
                name: "IX_Tickets_ConcertId",
                table: "Ticket",
                newName: "IX_Ticket_ConcertId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ticket",
                table: "Ticket",
                column: "TicketID");

            migrationBuilder.CreateTable(
                name: "BuyTicket",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TicketId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuyTicket", x => new { x.UserId, x.TicketId });
                    table.ForeignKey(
                        name: "FK_BuyTicket_Ticket_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Ticket",
                        principalColumn: "TicketID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuyTicket_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ReservedTicket",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TicketId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReservedTicket", x => new { x.UserId, x.TicketId });
                    table.ForeignKey(
                        name: "FK_ReservedTicket_Ticket_TicketId",
                        column: x => x.TicketId,
                        principalTable: "Ticket",
                        principalColumn: "TicketID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReservedTicket_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BuyTicket_TicketId",
                table: "BuyTicket",
                column: "TicketId");

            migrationBuilder.CreateIndex(
                name: "IX_ReservedTicket_TicketId",
                table: "ReservedTicket",
                column: "TicketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Concerts_ConcertId",
                table: "Ticket",
                column: "ConcertId",
                principalTable: "Concerts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

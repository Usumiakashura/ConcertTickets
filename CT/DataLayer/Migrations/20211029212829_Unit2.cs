using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class Unit2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InfoAboutDeleteTickets_DeletedTickeds_DeletedTicketId",
                table: "InfoAboutDeleteTickets");

            migrationBuilder.DropTable(
                name: "DeletedTickeds");

            migrationBuilder.CreateTable(
                name: "DeletedTickets",
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
                    table.PrimaryKey("PK_DeletedTickets", x => x.DelTicketId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_InfoAboutDeleteTickets_DeletedTickets_DeletedTicketId",
                table: "InfoAboutDeleteTickets",
                column: "DeletedTicketId",
                principalTable: "DeletedTickets",
                principalColumn: "DelTicketId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InfoAboutDeleteTickets_DeletedTickets_DeletedTicketId",
                table: "InfoAboutDeleteTickets");

            migrationBuilder.DropTable(
                name: "DeletedTickets");

            migrationBuilder.CreateTable(
                name: "DeletedTickeds",
                columns: table => new
                {
                    DelTicketId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateConcert = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Sector = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SingerDeletedConcert = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeletedTickeds", x => x.DelTicketId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_InfoAboutDeleteTickets_DeletedTickeds_DeletedTicketId",
                table: "InfoAboutDeleteTickets",
                column: "DeletedTicketId",
                principalTable: "DeletedTickeds",
                principalColumn: "DelTicketId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class Unit1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Concerts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Singer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateConcert = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Concerts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConcertTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConcertTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VoiceTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameVoiceType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VoiceTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InfoAboutTypeConcerts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcertTypeId = table.Column<int>(type: "int", nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameConcert = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Composer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VoiceTypeId = table.Column<int>(type: "int", nullable: true),
                    Headliner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HowToGetThere = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InfoAboutTypeConcerts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InfoAboutTypeConcerts_Concerts_Id",
                        column: x => x.Id,
                        principalTable: "Concerts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InfoAboutTypeConcerts_ConcertTypes_ConcertTypeId",
                        column: x => x.ConcertTypeId,
                        principalTable: "ConcertTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InfoAboutTypeConcerts_VoiceTypes_VoiceTypeId",
                        column: x => x.VoiceTypeId,
                        principalTable: "VoiceTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InfoAboutTypeConcerts_ConcertTypeId",
                table: "InfoAboutTypeConcerts",
                column: "ConcertTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_InfoAboutTypeConcerts_VoiceTypeId",
                table: "InfoAboutTypeConcerts",
                column: "VoiceTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InfoAboutTypeConcerts");

            migrationBuilder.DropTable(
                name: "Concerts");

            migrationBuilder.DropTable(
                name: "ConcertTypes");

            migrationBuilder.DropTable(
                name: "VoiceTypes");
        }
    }
}

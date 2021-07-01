using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect_paw_wf.Migrations
{
    public partial class MigrareCompanii : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companii",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nume = table.Column<string>(nullable: true),
                    TipBilete = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companii", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rute",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CompanieId = table.Column<int>(nullable: false),
                    Cod = table.Column<string>(nullable: true),
                    Plecare = table.Column<string>(nullable: true),
                    Destinatie = table.Column<string>(nullable: true),
                    DataPlecare = table.Column<DateTime>(nullable: false),
                    NrKm = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rute", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rute_Companii_CompanieId",
                        column: x => x.CompanieId,
                        principalTable: "Companii",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rute_CompanieId",
                table: "Rute",
                column: "CompanieId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rute");

            migrationBuilder.DropTable(
                name: "Companii");
        }
    }
}

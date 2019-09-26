using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PresidioWebAsp.Migrations
{
    public partial class PresidioDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cela",
                columns: table => new
                {
                    CelaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cela", x => x.CelaId);
                });

            migrationBuilder.CreateTable(
                name: "Presidiarios",
                columns: table => new
                {
                    PresidiarioId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    DataEntrada = table.Column<DateTime>(nullable: false),
                    DataSaida = table.Column<DateTime>(nullable: false),
                    Escolaridade = table.Column<int>(nullable: false),
                    CelaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Presidiarios", x => x.PresidiarioId);
                    table.ForeignKey(
                        name: "FK_Presidiarios_Cela_CelaId",
                        column: x => x.CelaId,
                        principalTable: "Cela",
                        principalColumn: "CelaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Presidiarios_CelaId",
                table: "Presidiarios",
                column: "CelaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Presidiarios");

            migrationBuilder.DropTable(
                name: "Cela");
        }
    }
}

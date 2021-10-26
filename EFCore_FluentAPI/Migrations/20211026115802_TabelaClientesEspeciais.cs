using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCore_FluentAPI.Migrations
{
    public partial class TabelaClientesEspeciais : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClientesEspeciais",
                columns: table => new
                {
                    Codigo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Ativo = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    DataNascimento = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientesEspeciais", x => x.Codigo);
                });

            migrationBuilder.InsertData(
                table: "ClientesEspeciais",
                columns: new[] { "Codigo", "DataNascimento", "Email", "Nome" },
                values: new object[] { 1, new DateTime(1975, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "maria@teste.com", "Maria" });

            migrationBuilder.CreateIndex(
                name: "IX_ClientesEspeciais_Nome",
                table: "ClientesEspeciais",
                column: "Nome");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClientesEspeciais");
        }
    }
}

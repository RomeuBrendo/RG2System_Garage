using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RG2System_Garage.Infra.Migrations
{
    public partial class CadastroFormaPagamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FormaPagamento",
                table: "Orcamento");

            migrationBuilder.CreateTable(
                name: "FormaPagamento",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Descricao = table.Column<string>(maxLength: 150, nullable: true),
                    Tipo = table.Column<int>(maxLength: 30, nullable: false),
                    PrazoRecebimento = table.Column<int>(maxLength: 150, nullable: false),
                    QuantidadeParcela = table.Column<int>(maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormaPagamento", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FormaPagamento");

            migrationBuilder.AddColumn<string>(
                name: "FormaPagamento",
                table: "Orcamento",
                type: "varchar(50) CHARACTER SET utf8mb4",
                maxLength: 50,
                nullable: true);
        }
    }
}

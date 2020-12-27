using Microsoft.EntityFrameworkCore.Migrations;

namespace RG2System_Garage.Infra.Migrations
{
    public partial class AjusteOrcamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orcamento_Cliente_ClienteId",
                table: "Orcamento");

            migrationBuilder.AddColumn<float>(
                name: "PrecoVenda",
                table: "OrcamentoItem",
                maxLength: 999999,
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddForeignKey(
                name: "FK_Orcamento_Cliente_ClienteId",
                table: "Orcamento",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orcamento_Cliente_ClienteId",
                table: "Orcamento");

            migrationBuilder.DropColumn(
                name: "PrecoVenda",
                table: "OrcamentoItem");

            migrationBuilder.AddForeignKey(
                name: "FK_Orcamento_Cliente_ClienteId",
                table: "Orcamento",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

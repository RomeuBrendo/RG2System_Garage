using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RG2System_Garage.Infra.Migrations
{
    public partial class AlteracaoProdutoServico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movimentacao_ProdutoServico_ProdutoServicoId",
                table: "Movimentacao");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "Movimentacao");

            migrationBuilder.AlterColumn<Guid>(
                name: "ProdutoServicoId",
                table: "Movimentacao",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Movimentacao_ProdutoServico_ProdutoServicoId",
                table: "Movimentacao",
                column: "ProdutoServicoId",
                principalTable: "ProdutoServico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movimentacao_ProdutoServico_ProdutoServicoId",
                table: "Movimentacao");

            migrationBuilder.AlterColumn<Guid>(
                name: "ProdutoServicoId",
                table: "Movimentacao",
                type: "char(36)",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<Guid>(
                name: "ProdutoId",
                table: "Movimentacao",
                type: "char(36)",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddForeignKey(
                name: "FK_Movimentacao_ProdutoServico_ProdutoServicoId",
                table: "Movimentacao",
                column: "ProdutoServicoId",
                principalTable: "ProdutoServico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

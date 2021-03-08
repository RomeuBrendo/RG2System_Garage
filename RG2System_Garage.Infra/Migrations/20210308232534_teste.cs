using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RG2System_Garage.Infra.Migrations
{
    public partial class teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ORPagamento_OrdemServico_OrdemServicoId1",
                table: "ORPagamento");

            migrationBuilder.DropIndex(
                name: "IX_ORPagamento_OrdemServicoId1",
                table: "ORPagamento");

            migrationBuilder.DropColumn(
                name: "OrdemServicoId1",
                table: "ORPagamento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "OrdemServicoId1",
                table: "ORPagamento",
                type: "char(36)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ORPagamento_OrdemServicoId1",
                table: "ORPagamento",
                column: "OrdemServicoId1");

            migrationBuilder.AddForeignKey(
                name: "FK_ORPagamento_OrdemServico_OrdemServicoId1",
                table: "ORPagamento",
                column: "OrdemServicoId1",
                principalTable: "OrdemServico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

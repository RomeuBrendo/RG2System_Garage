using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RG2System_Garage.Infra.Migrations
{
    public partial class InclusaoVeiculoOrcamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "VeiculoId",
                table: "Orcamento",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orcamento_VeiculoId",
                table: "Orcamento",
                column: "VeiculoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orcamento_Veiculos_VeiculoId",
                table: "Orcamento",
                column: "VeiculoId",
                principalTable: "Veiculos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orcamento_Veiculos_VeiculoId",
                table: "Orcamento");

            migrationBuilder.DropIndex(
                name: "IX_Orcamento_VeiculoId",
                table: "Orcamento");

            migrationBuilder.DropColumn(
                name: "VeiculoId",
                table: "Orcamento");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RG2System_Garage.Infra.Migrations
{
    public partial class teste5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdemServico_Orcamento_OrcamentoId",
                table: "OrdemServico");

            migrationBuilder.AlterColumn<double>(
                name: "Valor",
                table: "ORPagamento",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "float");

            migrationBuilder.AlterColumn<Guid>(
                name: "OrcamentoId",
                table: "OrdemServico",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdemServico_Orcamento_OrcamentoId",
                table: "OrdemServico",
                column: "OrcamentoId",
                principalTable: "Orcamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrdemServico_Orcamento_OrcamentoId",
                table: "OrdemServico");

            migrationBuilder.AlterColumn<float>(
                name: "Valor",
                table: "ORPagamento",
                type: "float",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<Guid>(
                name: "OrcamentoId",
                table: "OrdemServico",
                type: "char(36)",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddForeignKey(
                name: "FK_OrdemServico_Orcamento_OrcamentoId",
                table: "OrdemServico",
                column: "OrcamentoId",
                principalTable: "Orcamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

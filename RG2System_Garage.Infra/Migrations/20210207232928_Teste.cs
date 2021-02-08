using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RG2System_Garage.Infra.Migrations
{
    public partial class Teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ORPagamento_ORPagamento_FormaPagamentoId",
                table: "ORPagamento");

            migrationBuilder.DropForeignKey(
                name: "FK_ORPagamento_OrdemServico_FormaPagamentoId",
                table: "ORPagamento");

            migrationBuilder.DropForeignKey(
                name: "FK_ORPagamento_OrdemServico_OrdemServicoId",
                table: "ORPagamento");

            migrationBuilder.AlterColumn<Guid>(
                name: "OrdemServicoId",
                table: "ORPagamento",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "FormaPagamentoId",
                table: "ORPagamento",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataFinalizacao",
                table: "OrdemServico",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime(6)");

            migrationBuilder.AddForeignKey(
                name: "FK_ORPagamento_ORPagamento_FormaPagamentoId",
                table: "ORPagamento",
                column: "FormaPagamentoId",
                principalTable: "ORPagamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ORPagamento_OrdemServico_FormaPagamentoId",
                table: "ORPagamento",
                column: "FormaPagamentoId",
                principalTable: "OrdemServico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ORPagamento_OrdemServico_OrdemServicoId",
                table: "ORPagamento",
                column: "OrdemServicoId",
                principalTable: "OrdemServico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ORPagamento_ORPagamento_FormaPagamentoId",
                table: "ORPagamento");

            migrationBuilder.DropForeignKey(
                name: "FK_ORPagamento_OrdemServico_FormaPagamentoId",
                table: "ORPagamento");

            migrationBuilder.DropForeignKey(
                name: "FK_ORPagamento_OrdemServico_OrdemServicoId",
                table: "ORPagamento");

            migrationBuilder.AlterColumn<Guid>(
                name: "OrdemServicoId",
                table: "ORPagamento",
                type: "char(36)",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<Guid>(
                name: "FormaPagamentoId",
                table: "ORPagamento",
                type: "char(36)",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataFinalizacao",
                table: "OrdemServico",
                type: "datetime(6)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ORPagamento_ORPagamento_FormaPagamentoId",
                table: "ORPagamento",
                column: "FormaPagamentoId",
                principalTable: "ORPagamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ORPagamento_OrdemServico_FormaPagamentoId",
                table: "ORPagamento",
                column: "FormaPagamentoId",
                principalTable: "OrdemServico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ORPagamento_OrdemServico_OrdemServicoId",
                table: "ORPagamento",
                column: "OrdemServicoId",
                principalTable: "OrdemServico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

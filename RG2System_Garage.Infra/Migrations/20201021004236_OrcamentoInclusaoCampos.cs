using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RG2System_Garage.Infra.Migrations
{
    public partial class OrcamentoInclusaoCampos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orcamento_Clientes_ClienteId",
                table: "Orcamento");

            migrationBuilder.DropForeignKey(
                name: "FK_OrcamentoItem_Orcamento_OrcamentoId",
                table: "OrcamentoItem");

            migrationBuilder.DropForeignKey(
                name: "FK_OrcamentoItem_ProdutoServico_ProdutoId",
                table: "OrcamentoItem");

            migrationBuilder.DropIndex(
                name: "IX_OrcamentoItem_ProdutoId",
                table: "OrcamentoItem");

            migrationBuilder.DropIndex(
                name: "IX_Orcamento_ClienteId",
                table: "Orcamento");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "OrcamentoItem");

            migrationBuilder.AlterColumn<Guid>(
                name: "OrcamentoId",
                table: "OrcamentoItem",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProdutoServicoId",
                table: "OrcamentoItem",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "ClienteId",
                table: "Orcamento",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "char(36)",
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Numero",
                table: "Orcamento",
                nullable: false,
                defaultValue: 0L)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_OrcamentoItem_Orcamento_OrcamentoId",
                table: "OrcamentoItem",
                column: "OrcamentoId",
                principalTable: "Orcamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrcamentoItem_Orcamento_OrcamentoId",
                table: "OrcamentoItem");

            migrationBuilder.DropColumn(
                name: "ProdutoServicoId",
                table: "OrcamentoItem");

            migrationBuilder.DropColumn(
                name: "Numero",
                table: "Orcamento");

            migrationBuilder.AlterColumn<Guid>(
                name: "OrcamentoId",
                table: "OrcamentoItem",
                type: "char(36)",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<Guid>(
                name: "ProdutoId",
                table: "OrcamentoItem",
                type: "char(36)",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "ClienteId",
                table: "Orcamento",
                type: "char(36)",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.CreateIndex(
                name: "IX_OrcamentoItem_ProdutoId",
                table: "OrcamentoItem",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Orcamento_ClienteId",
                table: "Orcamento",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orcamento_Clientes_ClienteId",
                table: "Orcamento",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrcamentoItem_Orcamento_OrcamentoId",
                table: "OrcamentoItem",
                column: "OrcamentoId",
                principalTable: "Orcamento",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrcamentoItem_ProdutoServico_ProdutoId",
                table: "OrcamentoItem",
                column: "ProdutoId",
                principalTable: "ProdutoServico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

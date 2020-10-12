using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RG2System_Garage.Infra.Migrations
{
    public partial class Remocao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_EstoqueProdutos_EstoqueProdutoId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_EstoqueProdutoId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "EstoqueProdutoId",
                table: "Produtos");

            migrationBuilder.CreateIndex(
                name: "IX_EstoqueProdutos_ProdutoId",
                table: "EstoqueProdutos",
                column: "ProdutoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_EstoqueProdutos_Produtos_ProdutoId",
                table: "EstoqueProdutos",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EstoqueProdutos_Produtos_ProdutoId",
                table: "EstoqueProdutos");

            migrationBuilder.DropIndex(
                name: "IX_EstoqueProdutos_ProdutoId",
                table: "EstoqueProdutos");

            migrationBuilder.AddColumn<Guid>(
                name: "EstoqueProdutoId",
                table: "Produtos",
                type: "char(36)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_EstoqueProdutoId",
                table: "Produtos",
                column: "EstoqueProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_EstoqueProdutos_EstoqueProdutoId",
                table: "Produtos",
                column: "EstoqueProdutoId",
                principalTable: "EstoqueProdutos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

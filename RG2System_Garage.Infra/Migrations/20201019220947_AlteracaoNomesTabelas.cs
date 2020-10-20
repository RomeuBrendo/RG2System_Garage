using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RG2System_Garage.Infra.Migrations
{
    public partial class AlteracaoNomesTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrcamentoItem_Produtos_ProdutoId",
                table: "OrcamentoItem");

            migrationBuilder.DropTable(
                name: "EstoqueProdutos");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.CreateTable(
                name: "ProdutoServico",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Descricao = table.Column<string>(maxLength: 150, nullable: true),
                    Tipo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoServico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movimentacao",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ProdutoId = table.Column<Guid>(nullable: false),
                    DataLancamento = table.Column<DateTime>(nullable: false),
                    PrecoCusto = table.Column<float>(nullable: false),
                    PrecoVenda = table.Column<float>(nullable: false),
                    EstoqueAtual = table.Column<int>(nullable: false),
                    ProdutoServicoId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movimentacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movimentacao_ProdutoServico_ProdutoServicoId",
                        column: x => x.ProdutoServicoId,
                        principalTable: "ProdutoServico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Movimentacao_ProdutoServicoId",
                table: "Movimentacao",
                column: "ProdutoServicoId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrcamentoItem_ProdutoServico_ProdutoId",
                table: "OrcamentoItem",
                column: "ProdutoId",
                principalTable: "ProdutoServico",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrcamentoItem_ProdutoServico_ProdutoId",
                table: "OrcamentoItem");

            migrationBuilder.DropTable(
                name: "Movimentacao");

            migrationBuilder.DropTable(
                name: "ProdutoServico");

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(150) CHARACTER SET utf8mb4", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstoqueProdutos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    DataLancamento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    EstoqueAtual = table.Column<int>(type: "int", nullable: false),
                    PrecoCusto = table.Column<float>(type: "float", nullable: false),
                    PrecoVenda = table.Column<float>(type: "float", nullable: false),
                    ProdutoId = table.Column<Guid>(type: "char(36)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstoqueProdutos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EstoqueProdutos_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EstoqueProdutos_ProdutoId",
                table: "EstoqueProdutos",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrcamentoItem_Produtos_ProdutoId",
                table: "OrcamentoItem",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

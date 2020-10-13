using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RG2System_Garage.Infra.Migrations
{
    public partial class Inicial20 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(maxLength: 300, nullable: true),
                    CPFCNPJ = table.Column<string>(maxLength: 20, nullable: true),
                    Telefone1 = table.Column<string>(maxLength: 15, nullable: true),
                    Telefone2 = table.Column<string>(maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Descricao = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Veiculos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Placa = table.Column<string>(maxLength: 15, nullable: true),
                    Modelo = table.Column<string>(maxLength: 150, nullable: true),
                    Ano = table.Column<DateTime>(nullable: false),
                    ClienteId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veiculos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Veiculos_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EstoqueProdutos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ProdutoId = table.Column<Guid>(nullable: false),
                    DataLancamento = table.Column<DateTime>(nullable: false),
                    PrecoCusto = table.Column<float>(nullable: false),
                    PrecoVenda = table.Column<float>(nullable: false),
                    EstoqueAtual = table.Column<int>(nullable: false)
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

            migrationBuilder.CreateTable(
                name: "ClienteVeiculo",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ClienteId = table.Column<Guid>(nullable: true),
                    VeiculoId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClienteVeiculo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClienteVeiculo_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClienteVeiculo_Veiculos_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "Veiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClienteVeiculo_ClienteId",
                table: "ClienteVeiculo",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_ClienteVeiculo_VeiculoId",
                table: "ClienteVeiculo",
                column: "VeiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_EstoqueProdutos_ProdutoId",
                table: "EstoqueProdutos",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_ClienteId",
                table: "Veiculos",
                column: "ClienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClienteVeiculo");

            migrationBuilder.DropTable(
                name: "EstoqueProdutos");

            migrationBuilder.DropTable(
                name: "Veiculos");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}

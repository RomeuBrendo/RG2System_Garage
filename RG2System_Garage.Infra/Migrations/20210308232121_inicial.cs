using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RG2System_Garage.Infra.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
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
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ConfiguracaoDadosEmpresa",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    RazaoSocial = table.Column<string>(maxLength: 500, nullable: true),
                    NomeFantasia = table.Column<string>(maxLength: 500, nullable: true),
                    Fixo = table.Column<string>(maxLength: 16, nullable: true),
                    Celular = table.Column<string>(maxLength: 16, nullable: true),
                    Endereco = table.Column<string>(maxLength: 1000, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConfiguracaoDadosEmpresa", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormaPagamento",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Descricao = table.Column<string>(maxLength: 150, nullable: true),
                    Tipo = table.Column<int>(maxLength: 30, nullable: false),
                    PrazoRecebimento = table.Column<int>(maxLength: 150, nullable: false),
                    QuantidadeParcela = table.Column<int>(maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormaPagamento", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProdutoServico",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Descricao = table.Column<string>(maxLength: 150, nullable: true),
                    Tipo = table.Column<int>(nullable: false),
                    Observacao = table.Column<string>(maxLength: 2000, nullable: true, defaultValue: ""),
                    Situacao = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoServico", x => x.Id);
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
                        name: "FK_Veiculos_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Movimentacao",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ProdutoServicoId = table.Column<Guid>(nullable: false),
                    DataLancamento = table.Column<DateTime>(nullable: false),
                    PrecoCusto = table.Column<float>(nullable: false),
                    PrecoVenda = table.Column<float>(nullable: false),
                    EstoqueAtual = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movimentacao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movimentacao_ProdutoServico_ProdutoServicoId",
                        column: x => x.ProdutoServicoId,
                        principalTable: "ProdutoServico",
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
                        name: "FK_ClienteVeiculo_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClienteVeiculo_Veiculos_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "Veiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orcamento",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ClienteId = table.Column<Guid>(nullable: true),
                    VeiculoId = table.Column<Guid>(nullable: true),
                    Numero = table.Column<long>(nullable: false),
                    ValorTotal = table.Column<double>(nullable: false),
                    Desconto = table.Column<double>(nullable: false),
                    Acrescimo = table.Column<double>(nullable: false),
                    Observacao = table.Column<string>(maxLength: 1500, nullable: true),
                    DataCriacao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orcamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orcamento_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orcamento_Veiculos_VeiculoId",
                        column: x => x.VeiculoId,
                        principalTable: "Veiculos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrcamentoItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    OrcamentoId = table.Column<Guid>(nullable: false),
                    ProdutoServicoId = table.Column<Guid>(nullable: false),
                    PrecoVenda = table.Column<float>(maxLength: 999999, nullable: false),
                    Quantidade = table.Column<int>(maxLength: 9999, nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrcamentoItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrcamentoItem_Orcamento_OrcamentoId",
                        column: x => x.OrcamentoId,
                        principalTable: "Orcamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrdemServico",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Numero = table.Column<int>(nullable: false),
                    DataFinalizacao = table.Column<DateTime>(nullable: true),
                    Status = table.Column<int>(maxLength: 50, nullable: false),
                    Observacao = table.Column<string>(nullable: true),
                    OrcamentoId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdemServico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdemServico_Orcamento_OrcamentoId",
                        column: x => x.OrcamentoId,
                        principalTable: "Orcamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ORPagamento",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FormaPagamentoId = table.Column<Guid>(nullable: false),
                    OrdemServicoId = table.Column<Guid>(nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrdemServicoId1 = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORPagamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ORPagamento_FormaPagamento_FormaPagamentoId",
                        column: x => x.FormaPagamentoId,
                        principalTable: "FormaPagamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ORPagamento_OrdemServico_OrdemServicoId",
                        column: x => x.OrdemServicoId,
                        principalTable: "OrdemServico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ORPagamento_OrdemServico_OrdemServicoId1",
                        column: x => x.OrdemServicoId1,
                        principalTable: "OrdemServico",
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
                name: "IX_Movimentacao_ProdutoServicoId",
                table: "Movimentacao",
                column: "ProdutoServicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Orcamento_ClienteId",
                table: "Orcamento",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Orcamento_Numero",
                table: "Orcamento",
                column: "Numero",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orcamento_VeiculoId",
                table: "Orcamento",
                column: "VeiculoId");

            migrationBuilder.CreateIndex(
                name: "IX_OrcamentoItem_OrcamentoId",
                table: "OrcamentoItem",
                column: "OrcamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdemServico_Numero",
                table: "OrdemServico",
                column: "Numero");

            migrationBuilder.CreateIndex(
                name: "IX_OrdemServico_OrcamentoId",
                table: "OrdemServico",
                column: "OrcamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_ORPagamento_FormaPagamentoId",
                table: "ORPagamento",
                column: "FormaPagamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_ORPagamento_OrdemServicoId",
                table: "ORPagamento",
                column: "OrdemServicoId");

            migrationBuilder.CreateIndex(
                name: "IX_ORPagamento_OrdemServicoId1",
                table: "ORPagamento",
                column: "OrdemServicoId1");

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
                name: "ConfiguracaoDadosEmpresa");

            migrationBuilder.DropTable(
                name: "Movimentacao");

            migrationBuilder.DropTable(
                name: "OrcamentoItem");

            migrationBuilder.DropTable(
                name: "ORPagamento");

            migrationBuilder.DropTable(
                name: "ProdutoServico");

            migrationBuilder.DropTable(
                name: "FormaPagamento");

            migrationBuilder.DropTable(
                name: "OrdemServico");

            migrationBuilder.DropTable(
                name: "Orcamento");

            migrationBuilder.DropTable(
                name: "Veiculos");

            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RG2System_Garage.Infra.Migrations
{
    public partial class OrdemServico : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrdemServico",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    OrcamentoId = table.Column<Guid>(nullable: true),
                    DataFinalizacao = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(maxLength: 50, nullable: false),
                    Observacao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdemServico", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdemServico_Orcamento_OrcamentoId",
                        column: x => x.OrcamentoId,
                        principalTable: "Orcamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ORPagamento",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FormaPagamentoId = table.Column<Guid>(nullable: true),
                    OrdemServicoId = table.Column<Guid>(nullable: true),
                    Valor = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ORPagamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ORPagamento_ORPagamento_FormaPagamentoId",
                        column: x => x.FormaPagamentoId,
                        principalTable: "ORPagamento",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ORPagamento_OrdemServico_FormaPagamentoId",
                        column: x => x.FormaPagamentoId,
                        principalTable: "OrdemServico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ORPagamento_OrdemServico_OrdemServicoId",
                        column: x => x.OrdemServicoId,
                        principalTable: "OrdemServico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ORPagamento");

            migrationBuilder.DropTable(
                name: "OrdemServico");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RG2System_Garage.Infra.Migrations
{
    public partial class teste10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "ExisteOrdemServico",
                table: "Orcamento",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AlterColumn<Guid>(
                name: "ClienteId",
                table: "Orcamento",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(36)");

            migrationBuilder.CreateIndex(
                name: "IX_Orcamento_ClienteId",
                table: "Orcamento",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orcamento_Cliente_ClienteId",
                table: "Orcamento",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orcamento_Cliente_ClienteId",
                table: "Orcamento");

            migrationBuilder.DropIndex(
                name: "IX_Orcamento_ClienteId",
                table: "Orcamento");

            migrationBuilder.AlterColumn<bool>(
                name: "ExisteOrdemServico",
                table: "Orcamento",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<string>(
                name: "ClienteId",
                table: "Orcamento",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);
        }
    }
}

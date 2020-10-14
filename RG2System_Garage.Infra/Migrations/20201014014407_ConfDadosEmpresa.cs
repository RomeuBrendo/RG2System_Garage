using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RG2System_Garage.Infra.Migrations
{
    public partial class ConfDadosEmpresa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConfiguracaoDadosEmpresa");
        }
    }
}

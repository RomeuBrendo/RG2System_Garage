using Microsoft.EntityFrameworkCore.Migrations;

namespace RG2System_Garage.Infra.Migrations
{
    public partial class InclusaoCamposCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CPFCNPJ",
                table: "Clientes",
                maxLength: 20,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefone1",
                table: "Clientes",
                maxLength: 15,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefone2",
                table: "Clientes",
                maxLength: 15,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CPFCNPJ",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Telefone1",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "Telefone2",
                table: "Clientes");
        }
    }
}

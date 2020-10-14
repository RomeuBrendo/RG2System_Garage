using Microsoft.EntityFrameworkCore.Migrations;

namespace RG2System_Garage.Infra.Migrations
{
    public partial class AjusteEmail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "ConfiguracaoDadosEmpresa",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(16) CHARACTER SET utf8mb4",
                oldMaxLength: 16,
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "ConfiguracaoDadosEmpresa",
                type: "varchar(16) CHARACTER SET utf8mb4",
                maxLength: 16,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}

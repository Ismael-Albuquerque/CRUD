using Microsoft.EntityFrameworkCore.Migrations;

namespace HelpSMA.Migrations
{
    public partial class Dois : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Horario",
                table: "Help");

            migrationBuilder.DropColumn(
                name: "Responsavel",
                table: "Help");

            migrationBuilder.AddColumn<string>(
                name: "Horário",
                table: "Help",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Responsável",
                table: "Help",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Seção",
                table: "Help",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Solicitante",
                table: "Help",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Help",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Horário",
                table: "Help");

            migrationBuilder.DropColumn(
                name: "Responsável",
                table: "Help");

            migrationBuilder.DropColumn(
                name: "Seção",
                table: "Help");

            migrationBuilder.DropColumn(
                name: "Solicitante",
                table: "Help");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Help");

            migrationBuilder.AddColumn<string>(
                name: "Horario",
                table: "Help",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Responsavel",
                table: "Help",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

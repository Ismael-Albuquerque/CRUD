using Microsoft.EntityFrameworkCore.Migrations;

namespace HelpSMA.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Help",
                columns: table => new
                {
                    ReservaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Item = table.Column<string>(nullable: true),
                    Data = table.Column<string>(nullable: true),
                    Horario = table.Column<string>(nullable: true),
                    Prioridade = table.Column<string>(nullable: true),
                    Responsavel = table.Column<string>(nullable: true),
                    Ramal = table.Column<int>(nullable: false),
                    Mensagem = table.Column<string>(nullable: true),
                    Situação = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Help", x => x.ReservaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Help");
        }
    }
}

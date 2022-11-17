using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _00consoleEF.Migrations
{
    /// <inheritdoc />
    public partial class consoleEFmgtv221117 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ceps",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CEP = table.Column<string>(type: "TEXT", nullable: false),
                    UF = table.Column<string>(type: "TEXT", nullable: false),
                    Cidade = table.Column<string>(type: "TEXT", nullable: false),
                    Bairro = table.Column<string>(type: "TEXT", nullable: false),
                    Logradouro = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ceps", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ceps");
        }
    }
}

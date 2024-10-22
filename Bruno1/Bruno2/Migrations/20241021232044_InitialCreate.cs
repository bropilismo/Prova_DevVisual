using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bruno1.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Folhas",
                columns: table => new
                {
                    Valor = table.Column<double>(type: "REAL", nullable: false),
                    Quantidade = table.Column<decimal>(type: "TEXT", nullable: false),
                    Mes = table.Column<decimal>(type: "TEXT", nullable: false),
                    Ano = table.Column<decimal>(type: "TEXT", nullable: false),
                    FuncionarioId = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Folhas", x => x.Valor);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Folhas");
        }
    }
}

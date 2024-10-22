using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bruno1.Migrations
{
    /// <inheritdoc />
    public partial class socoosssss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "funcionarioId",
                table: "Funcionarios",
                newName: "FuncionarioId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FuncionarioId",
                table: "Funcionarios",
                newName: "funcionarioId");
        }
    }
}

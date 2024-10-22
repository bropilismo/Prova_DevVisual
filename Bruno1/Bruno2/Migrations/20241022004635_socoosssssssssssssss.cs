using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bruno1.Migrations
{
    /// <inheritdoc />
    public partial class socoosssssssssssssss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Folhas",
                table: "Folhas");

            migrationBuilder.AddColumn<string>(
                name: "folhaId",
                table: "Folhas",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "funcionarioId",
                table: "Folhas",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Folhas",
                table: "Folhas",
                column: "folhaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Folhas",
                table: "Folhas");

            migrationBuilder.DropColumn(
                name: "folhaId",
                table: "Folhas");

            migrationBuilder.DropColumn(
                name: "funcionarioId",
                table: "Folhas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Folhas",
                table: "Folhas",
                column: "valor");
        }
    }
}

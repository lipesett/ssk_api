using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiSSK.Migrations
{
    /// <inheritdoc />
    public partial class RemoveUniqueIndexOnCli_ID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_TRACADOS_CLI_ID",
                table: "TRACADOS");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_TRACADOS_CLI_ID",
                table: "TRACADOS",
                column: "CLI_ID",
                unique: true);
        }
    }
}

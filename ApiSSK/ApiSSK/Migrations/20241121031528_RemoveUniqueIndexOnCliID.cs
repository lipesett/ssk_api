using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiSSK.Migrations
{
    /// <inheritdoc />
    public partial class RemoveUniqueIndexOnCliID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_MELHOR_VOLTA_CLI_ID",
                table: "MELHOR_VOLTA");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_MELHOR_VOLTA_CLI_ID",
                table: "MELHOR_VOLTA",
                column: "CLI_ID",
                unique: true);
        }
    }
}

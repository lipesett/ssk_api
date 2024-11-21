using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiSSK.Migrations
{
    /// <inheritdoc />
    public partial class RemoveUniqueIndexOnMvd_ID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
            name: "IX_MELHOR_VOLTA_MVD_ID",
            table: "MELHOR_VOLTA");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_MELHOR_VOLTA_MVD_ID",
                table: "MELHOR_VOLTA",
                column: "MVD_ID",
                unique: true);
        }
    }
}

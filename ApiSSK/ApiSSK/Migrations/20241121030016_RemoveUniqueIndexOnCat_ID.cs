using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiSSK.Migrations
{
    /// <inheritdoc />
    public partial class RemoveUniqueIndexOnCat_ID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_CATEGORIA_DIVISAO_CAT_ID",
                table: "CATEGORIA_DIVISAO");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_CATEGORIA_DIVISAO_CAT_ID",
                table: "CATEGORIA_DIVISAO",
                column: "CAT_ID",
                unique: true);
        }
    }
}

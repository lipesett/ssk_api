using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiSSK.Migrations
{
    /// <inheritdoc />
    public partial class Trocando_Status_Por_Enum_Na_Tabela_Divisao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DIVISOES_STATUS_STA_ID",
                table: "DIVISOES");

            migrationBuilder.DropIndex(
                name: "IX_DIVISOES_STA_ID",
                table: "DIVISOES");

            migrationBuilder.DropColumn(
                name: "STA_ID",
                table: "DIVISOES");

            migrationBuilder.AddColumn<int>(
                name: "STATUS",
                table: "DIVISOES",
                type: "INT",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "STATUS",
                table: "DIVISOES");

            migrationBuilder.AddColumn<int>(
                name: "STA_ID",
                table: "DIVISOES",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DIVISOES_STA_ID",
                table: "DIVISOES",
                column: "STA_ID",
                unique: true,
                filter: "[STA_ID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_DIVISOES_STATUS_STA_ID",
                table: "DIVISOES",
                column: "STA_ID",
                principalTable: "STATUS",
                principalColumn: "STA_ID");
        }
    }
}

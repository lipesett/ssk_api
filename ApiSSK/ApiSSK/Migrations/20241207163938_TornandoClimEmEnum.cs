using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiSSK.Migrations
{
    /// <inheritdoc />
    public partial class TornandoClimEmEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MELHOR_VOLTA_CLIMA_CLI_ID",
                table: "MELHOR_VOLTA");

            migrationBuilder.DropForeignKey(
                name: "FK_TRACADOS_CLIMA_CLI_ID",
                table: "TRACADOS");

            migrationBuilder.DropTable(
                name: "CLIMA");

            migrationBuilder.DropIndex(
                name: "IX_TRACADOS_CLI_ID",
                table: "TRACADOS");

            migrationBuilder.DropIndex(
                name: "IX_MELHOR_VOLTA_CLI_ID",
                table: "MELHOR_VOLTA");

            migrationBuilder.DropColumn(
                name: "CLI_ID",
                table: "TRACADOS");

            migrationBuilder.DropColumn(
                name: "CLI_ID",
                table: "MELHOR_VOLTA");

            migrationBuilder.AddColumn<int>(
                name: "CLIMA",
                table: "TRACADOS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CLIMA",
                table: "MELHOR_VOLTA",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CLIMA",
                table: "TRACADOS");

            migrationBuilder.DropColumn(
                name: "CLIMA",
                table: "MELHOR_VOLTA");

            migrationBuilder.AddColumn<int>(
                name: "CLI_ID",
                table: "TRACADOS",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CLI_ID",
                table: "MELHOR_VOLTA",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CLIMA",
                columns: table => new
                {
                    CLI_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CLI_DESC = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIMA", x => x.CLI_ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TRACADOS_CLI_ID",
                table: "TRACADOS",
                column: "CLI_ID",
                unique: true,
                filter: "[CLI_ID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MELHOR_VOLTA_CLI_ID",
                table: "MELHOR_VOLTA",
                column: "CLI_ID",
                unique: true,
                filter: "[CLI_ID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_MELHOR_VOLTA_CLIMA_CLI_ID",
                table: "MELHOR_VOLTA",
                column: "CLI_ID",
                principalTable: "CLIMA",
                principalColumn: "CLI_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TRACADOS_CLIMA_CLI_ID",
                table: "TRACADOS",
                column: "CLI_ID",
                principalTable: "CLIMA",
                principalColumn: "CLI_ID");
        }
    }
}

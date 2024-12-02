using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiSSK.Migrations
{
    /// <inheritdoc />
    public partial class TornandoEntidadeSentidoEmEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TRACADOS_SENTIDO_SEN_ID",
                table: "TRACADOS");

            migrationBuilder.DropTable(
                name: "SENTIDO");

            migrationBuilder.DropIndex(
                name: "IX_TRACADOS_SEN_ID",
                table: "TRACADOS");

            migrationBuilder.AddColumn<int>(
                name: "SENTIDO",
                table: "TRACADOS",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SENTIDO",
                table: "TRACADOS");

            migrationBuilder.CreateTable(
                name: "SENTIDO",
                columns: table => new
                {
                    SEN_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SEN_DESCRICAO = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SENTIDO", x => x.SEN_ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TRACADOS_SEN_ID",
                table: "TRACADOS",
                column: "SEN_ID",
                unique: true,
                filter: "[SEN_ID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_TRACADOS_SENTIDO_SEN_ID",
                table: "TRACADOS",
                column: "SEN_ID",
                principalTable: "SENTIDO",
                principalColumn: "SEN_ID");
        }
    }
}

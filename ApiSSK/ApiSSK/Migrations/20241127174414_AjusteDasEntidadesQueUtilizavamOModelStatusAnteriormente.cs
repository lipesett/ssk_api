using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiSSK.Migrations
{
    /// <inheritdoc />
    public partial class AjusteDasEntidadesQueUtilizavamOModelStatusAnteriormente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CATEGORIAS_STATUS_STA_ID",
                table: "CATEGORIAS");

            migrationBuilder.DropForeignKey(
                name: "FK_PILOTO_STATUS_STA_ID",
                table: "PILOTO");

            migrationBuilder.DropForeignKey(
                name: "FK_TEMPORADAS_STATUS_STA_ID",
                table: "TEMPORADAS");

            migrationBuilder.DropTable(
                name: "STATUS");

            migrationBuilder.DropIndex(
                name: "IX_TEMPORADAS_STA_ID",
                table: "TEMPORADAS");

            migrationBuilder.DropIndex(
                name: "IX_PILOTO_STA_ID",
                table: "PILOTO");

            migrationBuilder.DropIndex(
                name: "IX_CATEGORIAS_STA_ID",
                table: "CATEGORIAS");

            migrationBuilder.DropColumn(
                name: "STA_ID",
                table: "TEMPORADAS");

            migrationBuilder.DropColumn(
                name: "STA_ID",
                table: "PILOTO");

            migrationBuilder.DropColumn(
                name: "STA_ID",
                table: "CATEGORIAS");

            migrationBuilder.AddColumn<int>(
                name: "STATUS",
                table: "TEMPORADAS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "STATUS",
                table: "PILOTO",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "STATUS",
                table: "CATEGORIAS",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "STATUS",
                table: "TEMPORADAS");

            migrationBuilder.DropColumn(
                name: "STATUS",
                table: "PILOTO");

            migrationBuilder.DropColumn(
                name: "STATUS",
                table: "CATEGORIAS");

            migrationBuilder.AddColumn<int>(
                name: "STA_ID",
                table: "TEMPORADAS",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "STA_ID",
                table: "PILOTO",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "STA_ID",
                table: "CATEGORIAS",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "STATUS",
                columns: table => new
                {
                    STA_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    STA_DESCRICAO = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_STATUS", x => x.STA_ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TEMPORADAS_STA_ID",
                table: "TEMPORADAS",
                column: "STA_ID",
                unique: true,
                filter: "[STA_ID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PILOTO_STA_ID",
                table: "PILOTO",
                column: "STA_ID",
                unique: true,
                filter: "[STA_ID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CATEGORIAS_STA_ID",
                table: "CATEGORIAS",
                column: "STA_ID",
                unique: true,
                filter: "[STA_ID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_CATEGORIAS_STATUS_STA_ID",
                table: "CATEGORIAS",
                column: "STA_ID",
                principalTable: "STATUS",
                principalColumn: "STA_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_PILOTO_STATUS_STA_ID",
                table: "PILOTO",
                column: "STA_ID",
                principalTable: "STATUS",
                principalColumn: "STA_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TEMPORADAS_STATUS_STA_ID",
                table: "TEMPORADAS",
                column: "STA_ID",
                principalTable: "STATUS",
                principalColumn: "STA_ID");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiSSK.Migrations
{
    /// <inheritdoc />
    public partial class RemoveRequiredRule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CALENDARIO_TEMPORADAS_TEM_ID",
                table: "CALENDARIO");

            migrationBuilder.DropForeignKey(
                name: "FK_CATEGORIAS_STATUS_STA_ID",
                table: "CATEGORIAS");

            migrationBuilder.DropForeignKey(
                name: "FK_DIVISOES_STATUS_STA_ID",
                table: "DIVISOES");

            migrationBuilder.DropForeignKey(
                name: "FK_INSCRICOES_CATEGORIAS_CAT_ID",
                table: "INSCRICOES");

            migrationBuilder.DropForeignKey(
                name: "FK_INSCRICOES_DIVISOES_DIV_ID",
                table: "INSCRICOES");

            migrationBuilder.DropForeignKey(
                name: "FK_INSCRICOES_PILOTO_PIL_ID",
                table: "INSCRICOES");

            migrationBuilder.DropForeignKey(
                name: "FK_INSCRICOES_TEMPORADAS_TEM_ID",
                table: "INSCRICOES");

            migrationBuilder.DropForeignKey(
                name: "FK_MELHOR_VOLTA_PILOTO_PIL_ID",
                table: "MELHOR_VOLTA");

            migrationBuilder.DropForeignKey(
                name: "FK_PILOTO_STATUS_STA_ID",
                table: "PILOTO");

            migrationBuilder.DropForeignKey(
                name: "FK_PONTUACAO_TEMPORADAS_TEM_ID",
                table: "PONTUACAO");

            migrationBuilder.DropForeignKey(
                name: "FK_PONTUACAO_PILOTO_ETAPA_CALENDARIO_CAL_ID",
                table: "PONTUACAO_PILOTO_ETAPA");

            migrationBuilder.DropForeignKey(
                name: "FK_PONTUACAO_PILOTO_ETAPA_PILOTO_PIL_ID",
                table: "PONTUACAO_PILOTO_ETAPA");

            migrationBuilder.DropForeignKey(
                name: "FK_PONTUACAO_PILOTO_ETAPA_PONTUACAO_PON_ID",
                table: "PONTUACAO_PILOTO_ETAPA");

            migrationBuilder.DropForeignKey(
                name: "FK_TEMPORADAS_STATUS_STA_ID",
                table: "TEMPORADAS");

            migrationBuilder.DropIndex(
                name: "IX_TEMPORADAS_STA_ID",
                table: "TEMPORADAS");

            migrationBuilder.DropIndex(
                name: "IX_PONTUACAO_PILOTO_ETAPA_CAL_ID",
                table: "PONTUACAO_PILOTO_ETAPA");

            migrationBuilder.DropIndex(
                name: "IX_PONTUACAO_PILOTO_ETAPA_PIL_ID",
                table: "PONTUACAO_PILOTO_ETAPA");

            migrationBuilder.DropIndex(
                name: "IX_PONTUACAO_PILOTO_ETAPA_PON_ID",
                table: "PONTUACAO_PILOTO_ETAPA");

            migrationBuilder.DropIndex(
                name: "IX_PONTUACAO_TEM_ID",
                table: "PONTUACAO");

            migrationBuilder.DropIndex(
                name: "IX_PILOTO_STA_ID",
                table: "PILOTO");

            migrationBuilder.DropIndex(
                name: "IX_MELHOR_VOLTA_PIL_ID",
                table: "MELHOR_VOLTA");

            migrationBuilder.DropIndex(
                name: "IX_INSCRICOES_CAT_ID",
                table: "INSCRICOES");

            migrationBuilder.DropIndex(
                name: "IX_INSCRICOES_DIV_ID",
                table: "INSCRICOES");

            migrationBuilder.DropIndex(
                name: "IX_INSCRICOES_PIL_ID",
                table: "INSCRICOES");

            migrationBuilder.DropIndex(
                name: "IX_INSCRICOES_TEM_ID",
                table: "INSCRICOES");

            migrationBuilder.DropIndex(
                name: "IX_DIVISOES_STA_ID",
                table: "DIVISOES");

            migrationBuilder.DropIndex(
                name: "IX_CATEGORIAS_STA_ID",
                table: "CATEGORIAS");

            migrationBuilder.DropIndex(
                name: "IX_CALENDARIO_TEM_ID",
                table: "CALENDARIO");

            migrationBuilder.AlterColumn<int>(
                name: "STA_ID",
                table: "TEMPORADAS",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PON_ID",
                table: "PONTUACAO_PILOTO_ETAPA",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PIL_ID",
                table: "PONTUACAO_PILOTO_ETAPA",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CAL_ID",
                table: "PONTUACAO_PILOTO_ETAPA",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TEM_ID",
                table: "PONTUACAO",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "STA_ID",
                table: "PILOTO",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PIL_ID",
                table: "MELHOR_VOLTA",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TEM_ID",
                table: "INSCRICOES",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PIL_ID",
                table: "INSCRICOES",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DIV_ID",
                table: "INSCRICOES",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CAT_ID",
                table: "INSCRICOES",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "STA_ID",
                table: "DIVISOES",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "STA_ID",
                table: "CATEGORIAS",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TEM_ID",
                table: "CALENDARIO",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_TEMPORADAS_STA_ID",
                table: "TEMPORADAS",
                column: "STA_ID",
                unique: true,
                filter: "[STA_ID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PONTUACAO_PILOTO_ETAPA_CAL_ID",
                table: "PONTUACAO_PILOTO_ETAPA",
                column: "CAL_ID",
                unique: true,
                filter: "[CAL_ID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PONTUACAO_PILOTO_ETAPA_PIL_ID",
                table: "PONTUACAO_PILOTO_ETAPA",
                column: "PIL_ID",
                unique: true,
                filter: "[PIL_ID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PONTUACAO_PILOTO_ETAPA_PON_ID",
                table: "PONTUACAO_PILOTO_ETAPA",
                column: "PON_ID",
                unique: true,
                filter: "[PON_ID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PONTUACAO_TEM_ID",
                table: "PONTUACAO",
                column: "TEM_ID",
                unique: true,
                filter: "[TEM_ID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_PILOTO_STA_ID",
                table: "PILOTO",
                column: "STA_ID",
                unique: true,
                filter: "[STA_ID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MELHOR_VOLTA_PIL_ID",
                table: "MELHOR_VOLTA",
                column: "PIL_ID",
                unique: true,
                filter: "[PIL_ID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_INSCRICOES_CAT_ID",
                table: "INSCRICOES",
                column: "CAT_ID",
                unique: true,
                filter: "[CAT_ID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_INSCRICOES_DIV_ID",
                table: "INSCRICOES",
                column: "DIV_ID",
                unique: true,
                filter: "[DIV_ID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_INSCRICOES_PIL_ID",
                table: "INSCRICOES",
                column: "PIL_ID",
                unique: true,
                filter: "[PIL_ID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_INSCRICOES_TEM_ID",
                table: "INSCRICOES",
                column: "TEM_ID",
                unique: true,
                filter: "[TEM_ID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_DIVISOES_STA_ID",
                table: "DIVISOES",
                column: "STA_ID",
                unique: true,
                filter: "[STA_ID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CATEGORIAS_STA_ID",
                table: "CATEGORIAS",
                column: "STA_ID",
                unique: true,
                filter: "[STA_ID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CALENDARIO_TEM_ID",
                table: "CALENDARIO",
                column: "TEM_ID",
                unique: true,
                filter: "[TEM_ID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_CALENDARIO_TEMPORADAS_TEM_ID",
                table: "CALENDARIO",
                column: "TEM_ID",
                principalTable: "TEMPORADAS",
                principalColumn: "TEM_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CATEGORIAS_STATUS_STA_ID",
                table: "CATEGORIAS",
                column: "STA_ID",
                principalTable: "STATUS",
                principalColumn: "STA_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_DIVISOES_STATUS_STA_ID",
                table: "DIVISOES",
                column: "STA_ID",
                principalTable: "STATUS",
                principalColumn: "STA_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_INSCRICOES_CATEGORIAS_CAT_ID",
                table: "INSCRICOES",
                column: "CAT_ID",
                principalTable: "CATEGORIAS",
                principalColumn: "CAT_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_INSCRICOES_DIVISOES_DIV_ID",
                table: "INSCRICOES",
                column: "DIV_ID",
                principalTable: "DIVISOES",
                principalColumn: "DIV_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_INSCRICOES_PILOTO_PIL_ID",
                table: "INSCRICOES",
                column: "PIL_ID",
                principalTable: "PILOTO",
                principalColumn: "PIL_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_INSCRICOES_TEMPORADAS_TEM_ID",
                table: "INSCRICOES",
                column: "TEM_ID",
                principalTable: "TEMPORADAS",
                principalColumn: "TEM_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_MELHOR_VOLTA_PILOTO_PIL_ID",
                table: "MELHOR_VOLTA",
                column: "PIL_ID",
                principalTable: "PILOTO",
                principalColumn: "PIL_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_PILOTO_STATUS_STA_ID",
                table: "PILOTO",
                column: "STA_ID",
                principalTable: "STATUS",
                principalColumn: "STA_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_PONTUACAO_TEMPORADAS_TEM_ID",
                table: "PONTUACAO",
                column: "TEM_ID",
                principalTable: "TEMPORADAS",
                principalColumn: "TEM_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_PONTUACAO_PILOTO_ETAPA_CALENDARIO_CAL_ID",
                table: "PONTUACAO_PILOTO_ETAPA",
                column: "CAL_ID",
                principalTable: "CALENDARIO",
                principalColumn: "CAL_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_PONTUACAO_PILOTO_ETAPA_PILOTO_PIL_ID",
                table: "PONTUACAO_PILOTO_ETAPA",
                column: "PIL_ID",
                principalTable: "PILOTO",
                principalColumn: "PIL_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_PONTUACAO_PILOTO_ETAPA_PONTUACAO_PON_ID",
                table: "PONTUACAO_PILOTO_ETAPA",
                column: "PON_ID",
                principalTable: "PONTUACAO",
                principalColumn: "PON_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TEMPORADAS_STATUS_STA_ID",
                table: "TEMPORADAS",
                column: "STA_ID",
                principalTable: "STATUS",
                principalColumn: "STA_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CALENDARIO_TEMPORADAS_TEM_ID",
                table: "CALENDARIO");

            migrationBuilder.DropForeignKey(
                name: "FK_CATEGORIAS_STATUS_STA_ID",
                table: "CATEGORIAS");

            migrationBuilder.DropForeignKey(
                name: "FK_DIVISOES_STATUS_STA_ID",
                table: "DIVISOES");

            migrationBuilder.DropForeignKey(
                name: "FK_INSCRICOES_CATEGORIAS_CAT_ID",
                table: "INSCRICOES");

            migrationBuilder.DropForeignKey(
                name: "FK_INSCRICOES_DIVISOES_DIV_ID",
                table: "INSCRICOES");

            migrationBuilder.DropForeignKey(
                name: "FK_INSCRICOES_PILOTO_PIL_ID",
                table: "INSCRICOES");

            migrationBuilder.DropForeignKey(
                name: "FK_INSCRICOES_TEMPORADAS_TEM_ID",
                table: "INSCRICOES");

            migrationBuilder.DropForeignKey(
                name: "FK_MELHOR_VOLTA_PILOTO_PIL_ID",
                table: "MELHOR_VOLTA");

            migrationBuilder.DropForeignKey(
                name: "FK_PILOTO_STATUS_STA_ID",
                table: "PILOTO");

            migrationBuilder.DropForeignKey(
                name: "FK_PONTUACAO_TEMPORADAS_TEM_ID",
                table: "PONTUACAO");

            migrationBuilder.DropForeignKey(
                name: "FK_PONTUACAO_PILOTO_ETAPA_CALENDARIO_CAL_ID",
                table: "PONTUACAO_PILOTO_ETAPA");

            migrationBuilder.DropForeignKey(
                name: "FK_PONTUACAO_PILOTO_ETAPA_PILOTO_PIL_ID",
                table: "PONTUACAO_PILOTO_ETAPA");

            migrationBuilder.DropForeignKey(
                name: "FK_PONTUACAO_PILOTO_ETAPA_PONTUACAO_PON_ID",
                table: "PONTUACAO_PILOTO_ETAPA");

            migrationBuilder.DropForeignKey(
                name: "FK_TEMPORADAS_STATUS_STA_ID",
                table: "TEMPORADAS");

            migrationBuilder.DropIndex(
                name: "IX_TEMPORADAS_STA_ID",
                table: "TEMPORADAS");

            migrationBuilder.DropIndex(
                name: "IX_PONTUACAO_PILOTO_ETAPA_CAL_ID",
                table: "PONTUACAO_PILOTO_ETAPA");

            migrationBuilder.DropIndex(
                name: "IX_PONTUACAO_PILOTO_ETAPA_PIL_ID",
                table: "PONTUACAO_PILOTO_ETAPA");

            migrationBuilder.DropIndex(
                name: "IX_PONTUACAO_PILOTO_ETAPA_PON_ID",
                table: "PONTUACAO_PILOTO_ETAPA");

            migrationBuilder.DropIndex(
                name: "IX_PONTUACAO_TEM_ID",
                table: "PONTUACAO");

            migrationBuilder.DropIndex(
                name: "IX_PILOTO_STA_ID",
                table: "PILOTO");

            migrationBuilder.DropIndex(
                name: "IX_MELHOR_VOLTA_PIL_ID",
                table: "MELHOR_VOLTA");

            migrationBuilder.DropIndex(
                name: "IX_INSCRICOES_CAT_ID",
                table: "INSCRICOES");

            migrationBuilder.DropIndex(
                name: "IX_INSCRICOES_DIV_ID",
                table: "INSCRICOES");

            migrationBuilder.DropIndex(
                name: "IX_INSCRICOES_PIL_ID",
                table: "INSCRICOES");

            migrationBuilder.DropIndex(
                name: "IX_INSCRICOES_TEM_ID",
                table: "INSCRICOES");

            migrationBuilder.DropIndex(
                name: "IX_DIVISOES_STA_ID",
                table: "DIVISOES");

            migrationBuilder.DropIndex(
                name: "IX_CATEGORIAS_STA_ID",
                table: "CATEGORIAS");

            migrationBuilder.DropIndex(
                name: "IX_CALENDARIO_TEM_ID",
                table: "CALENDARIO");

            migrationBuilder.AlterColumn<int>(
                name: "STA_ID",
                table: "TEMPORADAS",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PON_ID",
                table: "PONTUACAO_PILOTO_ETAPA",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PIL_ID",
                table: "PONTUACAO_PILOTO_ETAPA",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CAL_ID",
                table: "PONTUACAO_PILOTO_ETAPA",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TEM_ID",
                table: "PONTUACAO",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "STA_ID",
                table: "PILOTO",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PIL_ID",
                table: "MELHOR_VOLTA",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TEM_ID",
                table: "INSCRICOES",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PIL_ID",
                table: "INSCRICOES",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DIV_ID",
                table: "INSCRICOES",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CAT_ID",
                table: "INSCRICOES",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "STA_ID",
                table: "DIVISOES",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "STA_ID",
                table: "CATEGORIAS",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TEM_ID",
                table: "CALENDARIO",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TEMPORADAS_STA_ID",
                table: "TEMPORADAS",
                column: "STA_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PONTUACAO_PILOTO_ETAPA_CAL_ID",
                table: "PONTUACAO_PILOTO_ETAPA",
                column: "CAL_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PONTUACAO_PILOTO_ETAPA_PIL_ID",
                table: "PONTUACAO_PILOTO_ETAPA",
                column: "PIL_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PONTUACAO_PILOTO_ETAPA_PON_ID",
                table: "PONTUACAO_PILOTO_ETAPA",
                column: "PON_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PONTUACAO_TEM_ID",
                table: "PONTUACAO",
                column: "TEM_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PILOTO_STA_ID",
                table: "PILOTO",
                column: "STA_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MELHOR_VOLTA_PIL_ID",
                table: "MELHOR_VOLTA",
                column: "PIL_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_INSCRICOES_CAT_ID",
                table: "INSCRICOES",
                column: "CAT_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_INSCRICOES_DIV_ID",
                table: "INSCRICOES",
                column: "DIV_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_INSCRICOES_PIL_ID",
                table: "INSCRICOES",
                column: "PIL_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_INSCRICOES_TEM_ID",
                table: "INSCRICOES",
                column: "TEM_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DIVISOES_STA_ID",
                table: "DIVISOES",
                column: "STA_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CATEGORIAS_STA_ID",
                table: "CATEGORIAS",
                column: "STA_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CALENDARIO_TEM_ID",
                table: "CALENDARIO",
                column: "TEM_ID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CALENDARIO_TEMPORADAS_TEM_ID",
                table: "CALENDARIO",
                column: "TEM_ID",
                principalTable: "TEMPORADAS",
                principalColumn: "TEM_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CATEGORIAS_STATUS_STA_ID",
                table: "CATEGORIAS",
                column: "STA_ID",
                principalTable: "STATUS",
                principalColumn: "STA_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DIVISOES_STATUS_STA_ID",
                table: "DIVISOES",
                column: "STA_ID",
                principalTable: "STATUS",
                principalColumn: "STA_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_INSCRICOES_CATEGORIAS_CAT_ID",
                table: "INSCRICOES",
                column: "CAT_ID",
                principalTable: "CATEGORIAS",
                principalColumn: "CAT_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_INSCRICOES_DIVISOES_DIV_ID",
                table: "INSCRICOES",
                column: "DIV_ID",
                principalTable: "DIVISOES",
                principalColumn: "DIV_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_INSCRICOES_PILOTO_PIL_ID",
                table: "INSCRICOES",
                column: "PIL_ID",
                principalTable: "PILOTO",
                principalColumn: "PIL_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_INSCRICOES_TEMPORADAS_TEM_ID",
                table: "INSCRICOES",
                column: "TEM_ID",
                principalTable: "TEMPORADAS",
                principalColumn: "TEM_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MELHOR_VOLTA_PILOTO_PIL_ID",
                table: "MELHOR_VOLTA",
                column: "PIL_ID",
                principalTable: "PILOTO",
                principalColumn: "PIL_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PILOTO_STATUS_STA_ID",
                table: "PILOTO",
                column: "STA_ID",
                principalTable: "STATUS",
                principalColumn: "STA_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PONTUACAO_TEMPORADAS_TEM_ID",
                table: "PONTUACAO",
                column: "TEM_ID",
                principalTable: "TEMPORADAS",
                principalColumn: "TEM_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PONTUACAO_PILOTO_ETAPA_CALENDARIO_CAL_ID",
                table: "PONTUACAO_PILOTO_ETAPA",
                column: "CAL_ID",
                principalTable: "CALENDARIO",
                principalColumn: "CAL_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PONTUACAO_PILOTO_ETAPA_PILOTO_PIL_ID",
                table: "PONTUACAO_PILOTO_ETAPA",
                column: "PIL_ID",
                principalTable: "PILOTO",
                principalColumn: "PIL_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PONTUACAO_PILOTO_ETAPA_PONTUACAO_PON_ID",
                table: "PONTUACAO_PILOTO_ETAPA",
                column: "PON_ID",
                principalTable: "PONTUACAO",
                principalColumn: "PON_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TEMPORADAS_STATUS_STA_ID",
                table: "TEMPORADAS",
                column: "STA_ID",
                principalTable: "STATUS",
                principalColumn: "STA_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

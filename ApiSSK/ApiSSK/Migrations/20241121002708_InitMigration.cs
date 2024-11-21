using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiSSK.Migrations
{
    /// <inheritdoc />
    public partial class InitMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "KARTODROMOS",
                columns: table => new
                {
                    KAR_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KAR_NOME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    KAR_NOMCURTO = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    KAR_APELIDO = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KARTODROMOS", x => x.KAR_ID);
                });

            migrationBuilder.CreateTable(
                name: "MELHOR_VOLTA_DESC",
                columns: table => new
                {
                    MVD_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MVD_DESCRICAO = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MELHOR_VOLTA_DESC", x => x.MVD_ID);
                });

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

            migrationBuilder.CreateTable(
                name: "CATEGORIAS",
                columns: table => new
                {
                    CAT_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CAT_NOME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    STA_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CATEGORIAS", x => x.CAT_ID);
                    table.ForeignKey(
                        name: "FK_CATEGORIAS_STATUS_STA_ID",
                        column: x => x.STA_ID,
                        principalTable: "STATUS",
                        principalColumn: "STA_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DIVISOES",
                columns: table => new
                {
                    DIV_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DIV_NOME = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    STA_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DIVISOES", x => x.DIV_ID);
                    table.ForeignKey(
                        name: "FK_DIVISOES_STATUS_STA_ID",
                        column: x => x.STA_ID,
                        principalTable: "STATUS",
                        principalColumn: "STA_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PILOTO",
                columns: table => new
                {
                    PIL_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PIL_NOME = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    PIL_SOBRENOME = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    PIL_PODIUNS = table.Column<int>(type: "int", nullable: false),
                    PIL_CORRIDAS_OFC = table.Column<int>(type: "int", nullable: false),
                    PIL_CAMPEAO = table.Column<int>(type: "int", nullable: false),
                    PIL_MELHOR_CHEGADA = table.Column<int>(type: "int", nullable: false),
                    PIL_ULTIMA_TEMP = table.Column<int>(type: "int", nullable: false),
                    PIL_VOLTAS_RAPIDAS = table.Column<int>(type: "int", nullable: false),
                    PIL_POLE_POSITION = table.Column<int>(type: "int", nullable: false),
                    PIL_PESO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PIL_MELHOR_QUALI = table.Column<int>(type: "int", nullable: false),
                    PIL_LINKS_FOTOS = table.Column<string>(type: "nvarchar(1500)", maxLength: 1500, nullable: false),
                    STA_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PILOTO", x => x.PIL_ID);
                    table.ForeignKey(
                        name: "FK_PILOTO_STATUS_STA_ID",
                        column: x => x.STA_ID,
                        principalTable: "STATUS",
                        principalColumn: "STA_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TEMPORADAS",
                columns: table => new
                {
                    TEM_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TEM_NUMTEM = table.Column<int>(type: "int", nullable: false),
                    TEM_NOME = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    TEM_ETAPAS = table.Column<int>(type: "int", nullable: false),
                    TEM_INICIO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TEM_FINAL = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TEM_ANO = table.Column<int>(type: "int", nullable: false),
                    STA_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TEMPORADAS", x => x.TEM_ID);
                    table.ForeignKey(
                        name: "FK_TEMPORADAS_STATUS_STA_ID",
                        column: x => x.STA_ID,
                        principalTable: "STATUS",
                        principalColumn: "STA_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CATEGORIA_DIVISAO",
                columns: table => new
                {
                    CAT_ID = table.Column<int>(type: "int", nullable: false),
                    DIV_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CATEGORIA_DIVISAO", x => new { x.CAT_ID, x.DIV_ID });
                    table.ForeignKey(
                        name: "FK_CATEGORIA_DIVISAO_CATEGORIAS_CAT_ID",
                        column: x => x.CAT_ID,
                        principalTable: "CATEGORIAS",
                        principalColumn: "CAT_ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_CATEGORIA_DIVISAO_DIVISOES_DIV_ID",
                        column: x => x.DIV_ID,
                        principalTable: "DIVISOES",
                        principalColumn: "DIV_ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "INSCRICOES",
                columns: table => new
                {
                    INS_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    INS_DATA_INSCRICAO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    INS_PAGO = table.Column<bool>(type: "bit", nullable: false),
                    TEM_ID = table.Column<int>(type: "int", nullable: false),
                    PIL_ID = table.Column<int>(type: "int", nullable: false),
                    CAT_ID = table.Column<int>(type: "int", nullable: false),
                    DIV_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_INSCRICOES", x => x.INS_ID);
                    table.ForeignKey(
                        name: "FK_INSCRICOES_CATEGORIAS_CAT_ID",
                        column: x => x.CAT_ID,
                        principalTable: "CATEGORIAS",
                        principalColumn: "CAT_ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_INSCRICOES_DIVISOES_DIV_ID",
                        column: x => x.DIV_ID,
                        principalTable: "DIVISOES",
                        principalColumn: "DIV_ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_INSCRICOES_PILOTO_PIL_ID",
                        column: x => x.PIL_ID,
                        principalTable: "PILOTO",
                        principalColumn: "PIL_ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_INSCRICOES_TEMPORADAS_TEM_ID",
                        column: x => x.TEM_ID,
                        principalTable: "TEMPORADAS",
                        principalColumn: "TEM_ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "PONTUACAO",
                columns: table => new
                {
                    PON_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PON_POSICAO = table.Column<int>(type: "int", nullable: false),
                    PON_PONTOS = table.Column<int>(type: "int", nullable: false),
                    TEM_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PONTUACAO", x => x.PON_ID);
                    table.ForeignKey(
                        name: "FK_PONTUACAO_TEMPORADAS_TEM_ID",
                        column: x => x.TEM_ID,
                        principalTable: "TEMPORADAS",
                        principalColumn: "TEM_ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "CALENDARIO",
                columns: table => new
                {
                    CAL_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CAL_NOME_ETAPA = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CAL_NUM_ETAPA = table.Column<int>(type: "int", nullable: false),
                    CAL_DIA = table.Column<int>(type: "int", nullable: false),
                    CAL_MES = table.Column<int>(type: "int", nullable: false),
                    CAL_ANO = table.Column<int>(type: "int", nullable: false),
                    CAL_DATA_COMPLETA = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CAL_HORARIO = table.Column<TimeSpan>(type: "time", nullable: false),
                    CAL_PTS_DISPUTADOS = table.Column<int>(type: "int", nullable: false),
                    CAL_ETAPA_REALIZADA = table.Column<bool>(type: "bit", nullable: false),
                    TRA_ID = table.Column<int>(type: "int", nullable: true),
                    TEM_ID = table.Column<int>(type: "int", nullable: false),
                    PIL_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CALENDARIO", x => x.CAL_ID);
                    table.ForeignKey(
                        name: "FK_CALENDARIO_PILOTO_PIL_ID",
                        column: x => x.PIL_ID,
                        principalTable: "PILOTO",
                        principalColumn: "PIL_ID");
                    table.ForeignKey(
                        name: "FK_CALENDARIO_TEMPORADAS_TEM_ID",
                        column: x => x.TEM_ID,
                        principalTable: "TEMPORADAS",
                        principalColumn: "TEM_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MELHOR_VOLTA",
                columns: table => new
                {
                    MV_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MV_TEMPO = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    MVD_ID = table.Column<int>(type: "int", nullable: true),
                    PIL_ID = table.Column<int>(type: "int", nullable: false),
                    CLI_ID = table.Column<int>(type: "int", nullable: true),
                    CAL_ID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MELHOR_VOLTA", x => x.MV_ID);
                    table.ForeignKey(
                        name: "FK_MELHOR_VOLTA_CALENDARIO_CAL_ID",
                        column: x => x.CAL_ID,
                        principalTable: "CALENDARIO",
                        principalColumn: "CAL_ID");
                    table.ForeignKey(
                        name: "FK_MELHOR_VOLTA_CLIMA_CLI_ID",
                        column: x => x.CLI_ID,
                        principalTable: "CLIMA",
                        principalColumn: "CLI_ID");
                    table.ForeignKey(
                        name: "FK_MELHOR_VOLTA_MELHOR_VOLTA_DESC_MVD_ID",
                        column: x => x.MVD_ID,
                        principalTable: "MELHOR_VOLTA_DESC",
                        principalColumn: "MVD_ID");
                    table.ForeignKey(
                        name: "FK_MELHOR_VOLTA_PILOTO_PIL_ID",
                        column: x => x.PIL_ID,
                        principalTable: "PILOTO",
                        principalColumn: "PIL_ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PONTUACAO_PILOTO_ETAPA",
                columns: table => new
                {
                    PPE_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PPE_TEMPO_VOLTA = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PPE_MELHOR_VOLTA = table.Column<bool>(type: "bit", nullable: false),
                    PIL_ID = table.Column<int>(type: "int", nullable: false),
                    CAL_ID = table.Column<int>(type: "int", nullable: false),
                    PON_ID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PONTUACAO_PILOTO_ETAPA", x => x.PPE_ID);
                    table.ForeignKey(
                        name: "FK_PONTUACAO_PILOTO_ETAPA_CALENDARIO_CAL_ID",
                        column: x => x.CAL_ID,
                        principalTable: "CALENDARIO",
                        principalColumn: "CAL_ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PONTUACAO_PILOTO_ETAPA_PILOTO_PIL_ID",
                        column: x => x.PIL_ID,
                        principalTable: "PILOTO",
                        principalColumn: "PIL_ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_PONTUACAO_PILOTO_ETAPA_PONTUACAO_PON_ID",
                        column: x => x.PON_ID,
                        principalTable: "PONTUACAO",
                        principalColumn: "PON_ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "TRACADOS",
                columns: table => new
                {
                    TRA_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TRA_NOME = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TRA_DATA_ESTREIA = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KAR_ID = table.Column<int>(type: "int", nullable: false),
                    SEN_ID = table.Column<int>(type: "int", nullable: true),
                    CLI_ID = table.Column<int>(type: "int", nullable: true),
                    MV_ESTREIA_ID = table.Column<int>(type: "int", nullable: true),
                    MV_RECORD_ID = table.Column<int>(type: "int", nullable: true),
                    TRA_IMG = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TRACADOS", x => x.TRA_ID);
                    table.ForeignKey(
                        name: "FK_TRACADOS_CLIMA_CLI_ID",
                        column: x => x.CLI_ID,
                        principalTable: "CLIMA",
                        principalColumn: "CLI_ID");
                    table.ForeignKey(
                        name: "FK_TRACADOS_KARTODROMOS_KAR_ID",
                        column: x => x.KAR_ID,
                        principalTable: "KARTODROMOS",
                        principalColumn: "KAR_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TRACADOS_MELHOR_VOLTA_MV_ESTREIA_ID",
                        column: x => x.MV_ESTREIA_ID,
                        principalTable: "MELHOR_VOLTA",
                        principalColumn: "MV_ID");
                    table.ForeignKey(
                        name: "FK_TRACADOS_MELHOR_VOLTA_MV_RECORD_ID",
                        column: x => x.MV_RECORD_ID,
                        principalTable: "MELHOR_VOLTA",
                        principalColumn: "MV_ID");
                    table.ForeignKey(
                        name: "FK_TRACADOS_SENTIDO_SEN_ID",
                        column: x => x.SEN_ID,
                        principalTable: "SENTIDO",
                        principalColumn: "SEN_ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CALENDARIO_PIL_ID",
                table: "CALENDARIO",
                column: "PIL_ID",
                unique: true,
                filter: "[PIL_ID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CALENDARIO_TEM_ID",
                table: "CALENDARIO",
                column: "TEM_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CALENDARIO_TRA_ID",
                table: "CALENDARIO",
                column: "TRA_ID",
                unique: true,
                filter: "[TRA_ID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CATEGORIA_DIVISAO_CAT_ID",
                table: "CATEGORIA_DIVISAO",
                column: "CAT_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CATEGORIA_DIVISAO_DIV_ID",
                table: "CATEGORIA_DIVISAO",
                column: "DIV_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CATEGORIAS_STA_ID",
                table: "CATEGORIAS",
                column: "STA_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DIVISOES_STA_ID",
                table: "DIVISOES",
                column: "STA_ID",
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
                name: "IX_MELHOR_VOLTA_CAL_ID",
                table: "MELHOR_VOLTA",
                column: "CAL_ID",
                unique: true,
                filter: "[CAL_ID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MELHOR_VOLTA_CLI_ID",
                table: "MELHOR_VOLTA",
                column: "CLI_ID",
                unique: true,
                filter: "[CLI_ID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MELHOR_VOLTA_MVD_ID",
                table: "MELHOR_VOLTA",
                column: "MVD_ID",
                unique: true,
                filter: "[MVD_ID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MELHOR_VOLTA_PIL_ID",
                table: "MELHOR_VOLTA",
                column: "PIL_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PILOTO_STA_ID",
                table: "PILOTO",
                column: "STA_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PONTUACAO_TEM_ID",
                table: "PONTUACAO",
                column: "TEM_ID",
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
                name: "IX_TEMPORADAS_STA_ID",
                table: "TEMPORADAS",
                column: "STA_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TRACADOS_CLI_ID",
                table: "TRACADOS",
                column: "CLI_ID",
                unique: true,
                filter: "[CLI_ID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TRACADOS_KAR_ID",
                table: "TRACADOS",
                column: "KAR_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TRACADOS_MV_ESTREIA_ID",
                table: "TRACADOS",
                column: "MV_ESTREIA_ID",
                unique: true,
                filter: "[MV_ESTREIA_ID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TRACADOS_MV_RECORD_ID",
                table: "TRACADOS",
                column: "MV_RECORD_ID",
                unique: true,
                filter: "[MV_RECORD_ID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_TRACADOS_SEN_ID",
                table: "TRACADOS",
                column: "SEN_ID",
                unique: true,
                filter: "[SEN_ID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_CALENDARIO_TRACADOS_TRA_ID",
                table: "CALENDARIO",
                column: "TRA_ID",
                principalTable: "TRACADOS",
                principalColumn: "TRA_ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CALENDARIO_PILOTO_PIL_ID",
                table: "CALENDARIO");

            migrationBuilder.DropForeignKey(
                name: "FK_MELHOR_VOLTA_PILOTO_PIL_ID",
                table: "MELHOR_VOLTA");

            migrationBuilder.DropForeignKey(
                name: "FK_CALENDARIO_TEMPORADAS_TEM_ID",
                table: "CALENDARIO");

            migrationBuilder.DropForeignKey(
                name: "FK_CALENDARIO_TRACADOS_TRA_ID",
                table: "CALENDARIO");

            migrationBuilder.DropTable(
                name: "CATEGORIA_DIVISAO");

            migrationBuilder.DropTable(
                name: "INSCRICOES");

            migrationBuilder.DropTable(
                name: "PONTUACAO_PILOTO_ETAPA");

            migrationBuilder.DropTable(
                name: "CATEGORIAS");

            migrationBuilder.DropTable(
                name: "DIVISOES");

            migrationBuilder.DropTable(
                name: "PONTUACAO");

            migrationBuilder.DropTable(
                name: "PILOTO");

            migrationBuilder.DropTable(
                name: "TEMPORADAS");

            migrationBuilder.DropTable(
                name: "STATUS");

            migrationBuilder.DropTable(
                name: "TRACADOS");

            migrationBuilder.DropTable(
                name: "KARTODROMOS");

            migrationBuilder.DropTable(
                name: "MELHOR_VOLTA");

            migrationBuilder.DropTable(
                name: "SENTIDO");

            migrationBuilder.DropTable(
                name: "CALENDARIO");

            migrationBuilder.DropTable(
                name: "CLIMA");

            migrationBuilder.DropTable(
                name: "MELHOR_VOLTA_DESC");
        }
    }
}

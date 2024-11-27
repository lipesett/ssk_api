﻿// <auto-generated />
using System;
using ApiSSK.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiSSK.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20241125210956_Trocando_Status_Por_Enum_Na_Tabela_Divisao")]
    partial class Trocando_Status_Por_Enum_Na_Tabela_Divisao
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CalendarioModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CAL_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Ano")
                        .HasColumnType("int")
                        .HasColumnName("CAL_ANO");

                    b.Property<DateTime>("DataCompleta")
                        .HasColumnType("datetime2")
                        .HasColumnName("CAL_DATA_COMPLETA");

                    b.Property<int>("Dia")
                        .HasColumnType("int")
                        .HasColumnName("CAL_DIA");

                    b.Property<bool>("EtapaRealizada")
                        .HasColumnType("bit")
                        .HasColumnName("CAL_ETAPA_REALIZADA");

                    b.Property<TimeSpan>("Horario")
                        .HasColumnType("time")
                        .HasColumnName("CAL_HORARIO");

                    b.Property<int>("Mes")
                        .HasColumnType("int")
                        .HasColumnName("CAL_MES");

                    b.Property<string>("NomeEtapa")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("CAL_NOME_ETAPA");

                    b.Property<int>("NumEtapa")
                        .HasColumnType("int")
                        .HasColumnName("CAL_NUM_ETAPA");

                    b.Property<int?>("PilotoId")
                        .HasColumnType("int")
                        .HasColumnName("PIL_ID");

                    b.Property<int>("PtsDisputados")
                        .HasColumnType("int")
                        .HasColumnName("CAL_PTS_DISPUTADOS");

                    b.Property<int?>("TemporadaId")
                        .HasColumnType("int")
                        .HasColumnName("TEM_ID");

                    b.Property<int?>("TracadoId")
                        .HasColumnType("int")
                        .HasColumnName("TRA_ID");

                    b.HasKey("Id");

                    b.HasIndex("PilotoId")
                        .IsUnique()
                        .HasFilter("[PIL_ID] IS NOT NULL");

                    b.HasIndex("TemporadaId")
                        .IsUnique()
                        .HasFilter("[TEM_ID] IS NOT NULL");

                    b.HasIndex("TracadoId")
                        .IsUnique()
                        .HasFilter("[TRA_ID] IS NOT NULL");

                    b.ToTable("CALENDARIO", (string)null);
                });

            modelBuilder.Entity("CategoriaDivisaoModel", b =>
                {
                    b.Property<int>("CategoriaId")
                        .HasColumnType("int")
                        .HasColumnName("CAT_ID");

                    b.Property<int>("DivisaoId")
                        .HasColumnType("int")
                        .HasColumnName("DIV_ID");

                    b.HasKey("CategoriaId", "DivisaoId");

                    b.HasIndex("CategoriaId")
                        .IsUnique();

                    b.HasIndex("DivisaoId")
                        .IsUnique();

                    b.ToTable("CATEGORIA_DIVISAO", (string)null);
                });

            modelBuilder.Entity("CategoriaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CAT_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("CAT_NOME");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int")
                        .HasColumnName("STA_ID");

                    b.HasKey("Id");

                    b.HasIndex("StatusId")
                        .IsUnique()
                        .HasFilter("[STA_ID] IS NOT NULL");

                    b.ToTable("CATEGORIAS", (string)null);
                });

            modelBuilder.Entity("ClimaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CLI_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("CLI_DESC");

                    b.HasKey("Id");

                    b.ToTable("CLIMA", (string)null);
                });

            modelBuilder.Entity("DivisaoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("DIV_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("DIV_NOME");

                    b.Property<int>("Status")
                        .HasColumnType("INT")
                        .HasColumnName("STATUS");

                    b.HasKey("Id");

                    b.ToTable("DIVISOES", (string)null);
                });

            modelBuilder.Entity("InscricaoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("INS_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoriaId")
                        .HasColumnType("int")
                        .HasColumnName("CAT_ID");

                    b.Property<DateTime>("DataInscricao")
                        .HasColumnType("datetime2")
                        .HasColumnName("INS_DATA_INSCRICAO");

                    b.Property<int?>("DivisaoId")
                        .HasColumnType("int")
                        .HasColumnName("DIV_ID");

                    b.Property<bool>("Pago")
                        .HasColumnType("bit")
                        .HasColumnName("INS_PAGO");

                    b.Property<int?>("PilotoId")
                        .HasColumnType("int")
                        .HasColumnName("PIL_ID");

                    b.Property<int?>("TemporadaId")
                        .HasColumnType("int")
                        .HasColumnName("TEM_ID");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId")
                        .IsUnique()
                        .HasFilter("[CAT_ID] IS NOT NULL");

                    b.HasIndex("DivisaoId")
                        .IsUnique()
                        .HasFilter("[DIV_ID] IS NOT NULL");

                    b.HasIndex("PilotoId")
                        .IsUnique()
                        .HasFilter("[PIL_ID] IS NOT NULL");

                    b.HasIndex("TemporadaId")
                        .IsUnique()
                        .HasFilter("[TEM_ID] IS NOT NULL");

                    b.ToTable("INSCRICOES", (string)null);
                });

            modelBuilder.Entity("KartodromoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("KAR_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apelido")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("KAR_APELIDO");

                    b.Property<string>("NomCurto")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("KAR_NOMCURTO");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("KAR_NOME");

                    b.HasKey("Id");

                    b.ToTable("KARTODROMOS", (string)null);
                });

            modelBuilder.Entity("MelhorVoltaDescModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MVD_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("MVD_DESCRICAO");

                    b.HasKey("Id");

                    b.ToTable("MELHOR_VOLTA_DESC", (string)null);
                });

            modelBuilder.Entity("MelhorVoltaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MV_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CalendarioId")
                        .HasColumnType("int")
                        .HasColumnName("CAL_ID");

                    b.Property<int?>("ClimaId")
                        .HasColumnType("int")
                        .HasColumnName("CLI_ID");

                    b.Property<int?>("MelhorVoltaDescId")
                        .HasColumnType("int")
                        .HasColumnName("MVD_ID");

                    b.Property<int?>("PilotoId")
                        .HasColumnType("int")
                        .HasColumnName("PIL_ID");

                    b.Property<string>("Tempo")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("MV_TEMPO");

                    b.HasKey("Id");

                    b.HasIndex("CalendarioId")
                        .IsUnique()
                        .HasFilter("[CAL_ID] IS NOT NULL");

                    b.HasIndex("ClimaId")
                        .IsUnique()
                        .HasFilter("[CLI_ID] IS NOT NULL");

                    b.HasIndex("MelhorVoltaDescId")
                        .IsUnique()
                        .HasFilter("[MVD_ID] IS NOT NULL");

                    b.HasIndex("PilotoId")
                        .IsUnique()
                        .HasFilter("[PIL_ID] IS NOT NULL");

                    b.ToTable("MELHOR_VOLTA", (string)null);
                });

            modelBuilder.Entity("PilotoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PIL_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Campeao")
                        .HasColumnType("int")
                        .HasColumnName("PIL_CAMPEAO");

                    b.Property<int>("CorridasOfc")
                        .HasColumnType("int")
                        .HasColumnName("PIL_CORRIDAS_OFC");

                    b.Property<string>("LinksFotos")
                        .IsRequired()
                        .HasMaxLength(1500)
                        .HasColumnType("nvarchar(1500)")
                        .HasColumnName("PIL_LINKS_FOTOS");

                    b.Property<int>("MelhorChegada")
                        .HasColumnType("int")
                        .HasColumnName("PIL_MELHOR_CHEGADA");

                    b.Property<int>("MelhorQuali")
                        .HasColumnType("int")
                        .HasColumnName("PIL_MELHOR_QUALI");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasColumnName("PIL_NOME");

                    b.Property<string>("Peso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PIL_PESO");

                    b.Property<int>("Podiuns")
                        .HasColumnType("int")
                        .HasColumnName("PIL_PODIUNS");

                    b.Property<int>("PolePosition")
                        .HasColumnType("int")
                        .HasColumnName("PIL_POLE_POSITION");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)")
                        .HasColumnName("PIL_SOBRENOME");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int")
                        .HasColumnName("STA_ID");

                    b.Property<int>("UltimaTemp")
                        .HasColumnType("int")
                        .HasColumnName("PIL_ULTIMA_TEMP");

                    b.Property<int>("VoltasRapidas")
                        .HasColumnType("int")
                        .HasColumnName("PIL_VOLTAS_RAPIDAS");

                    b.HasKey("Id");

                    b.HasIndex("StatusId")
                        .IsUnique()
                        .HasFilter("[STA_ID] IS NOT NULL");

                    b.ToTable("PILOTO", (string)null);
                });

            modelBuilder.Entity("PontuacaoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PON_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Pontos")
                        .HasColumnType("int")
                        .HasColumnName("PON_PONTOS");

                    b.Property<int>("Posicao")
                        .HasColumnType("int")
                        .HasColumnName("PON_POSICAO");

                    b.Property<int?>("TemporadaId")
                        .HasColumnType("int")
                        .HasColumnName("TEM_ID");

                    b.HasKey("Id");

                    b.HasIndex("TemporadaId")
                        .IsUnique()
                        .HasFilter("[TEM_ID] IS NOT NULL");

                    b.ToTable("PONTUACAO", (string)null);
                });

            modelBuilder.Entity("PontuacaoPilotoEtapaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PPE_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CalendarioId")
                        .HasColumnType("int")
                        .HasColumnName("CAL_ID");

                    b.Property<bool>("MelhorVolta")
                        .HasColumnType("bit")
                        .HasColumnName("PPE_MELHOR_VOLTA");

                    b.Property<int?>("PilotoId")
                        .HasColumnType("int")
                        .HasColumnName("PIL_ID");

                    b.Property<int?>("PontuacaoId")
                        .HasColumnType("int")
                        .HasColumnName("PON_ID");

                    b.Property<string>("TempoMelhorVolta")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("PPE_TEMPO_VOLTA");

                    b.HasKey("Id");

                    b.HasIndex("CalendarioId")
                        .IsUnique()
                        .HasFilter("[CAL_ID] IS NOT NULL");

                    b.HasIndex("PilotoId")
                        .IsUnique()
                        .HasFilter("[PIL_ID] IS NOT NULL");

                    b.HasIndex("PontuacaoId")
                        .IsUnique()
                        .HasFilter("[PON_ID] IS NOT NULL");

                    b.ToTable("PONTUACAO_PILOTO_ETAPA", (string)null);
                });

            modelBuilder.Entity("SentidoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("SEN_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("SEN_DESCRICAO");

                    b.HasKey("Id");

                    b.ToTable("SENTIDO", (string)null);
                });

            modelBuilder.Entity("StatusModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("STA_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasColumnName("STA_DESCRICAO");

                    b.HasKey("Id");

                    b.ToTable("STATUS", (string)null);
                });

            modelBuilder.Entity("TemporadaModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TEM_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Ano")
                        .HasColumnType("int")
                        .HasColumnName("TEM_ANO");

                    b.Property<int>("Etapas")
                        .HasColumnType("int")
                        .HasColumnName("TEM_ETAPAS");

                    b.Property<DateTime>("Final")
                        .HasColumnType("datetime2")
                        .HasColumnName("TEM_FINAL");

                    b.Property<DateTime>("Inicio")
                        .HasColumnType("datetime2")
                        .HasColumnName("TEM_INICIO");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)")
                        .HasColumnName("TEM_NOME");

                    b.Property<int>("NumTem")
                        .HasColumnType("int")
                        .HasColumnName("TEM_NUMTEM");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int")
                        .HasColumnName("STA_ID");

                    b.HasKey("Id");

                    b.HasIndex("StatusId")
                        .IsUnique()
                        .HasFilter("[STA_ID] IS NOT NULL");

                    b.ToTable("TEMPORADAS", (string)null);
                });

            modelBuilder.Entity("TracadoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TRA_ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("ClimaId")
                        .HasColumnType("int")
                        .HasColumnName("CLI_ID");

                    b.Property<DateTime>("DataEstreia")
                        .HasColumnType("datetime2")
                        .HasColumnName("TRA_DATA_ESTREIA");

                    b.Property<string>("Img")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("TRA_IMG");

                    b.Property<int>("KartodromoId")
                        .HasColumnType("int")
                        .HasColumnName("KAR_ID");

                    b.Property<int?>("MvEstreiaId")
                        .HasColumnType("int")
                        .HasColumnName("MV_ESTREIA_ID");

                    b.Property<int?>("MvRecordId")
                        .HasColumnType("int")
                        .HasColumnName("MV_RECORD_ID");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("TRA_NOME");

                    b.Property<int?>("SentidoId")
                        .HasColumnType("int")
                        .HasColumnName("SEN_ID");

                    b.HasKey("Id");

                    b.HasIndex("ClimaId")
                        .IsUnique()
                        .HasFilter("[CLI_ID] IS NOT NULL");

                    b.HasIndex("KartodromoId")
                        .IsUnique();

                    b.HasIndex("MvEstreiaId")
                        .IsUnique()
                        .HasFilter("[MV_ESTREIA_ID] IS NOT NULL");

                    b.HasIndex("MvRecordId")
                        .IsUnique()
                        .HasFilter("[MV_RECORD_ID] IS NOT NULL");

                    b.HasIndex("SentidoId")
                        .IsUnique()
                        .HasFilter("[SEN_ID] IS NOT NULL");

                    b.ToTable("TRACADOS", (string)null);
                });

            modelBuilder.Entity("CalendarioModel", b =>
                {
                    b.HasOne("PilotoModel", "Piloto")
                        .WithOne()
                        .HasForeignKey("CalendarioModel", "PilotoId");

                    b.HasOne("TemporadaModel", "Temporada")
                        .WithOne()
                        .HasForeignKey("CalendarioModel", "TemporadaId");

                    b.HasOne("TracadoModel", "Tracado")
                        .WithOne()
                        .HasForeignKey("CalendarioModel", "TracadoId");

                    b.Navigation("Piloto");

                    b.Navigation("Temporada");

                    b.Navigation("Tracado");
                });

            modelBuilder.Entity("CategoriaDivisaoModel", b =>
                {
                    b.HasOne("CategoriaModel", "Categoria")
                        .WithOne()
                        .HasForeignKey("CategoriaDivisaoModel", "CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DivisaoModel", "Divisao")
                        .WithOne()
                        .HasForeignKey("CategoriaDivisaoModel", "DivisaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");

                    b.Navigation("Divisao");
                });

            modelBuilder.Entity("CategoriaModel", b =>
                {
                    b.HasOne("StatusModel", "Status")
                        .WithOne()
                        .HasForeignKey("CategoriaModel", "StatusId");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("InscricaoModel", b =>
                {
                    b.HasOne("CategoriaModel", "Categoria")
                        .WithOne()
                        .HasForeignKey("InscricaoModel", "CategoriaId");

                    b.HasOne("DivisaoModel", "Divisao")
                        .WithOne()
                        .HasForeignKey("InscricaoModel", "DivisaoId");

                    b.HasOne("PilotoModel", "Piloto")
                        .WithOne()
                        .HasForeignKey("InscricaoModel", "PilotoId");

                    b.HasOne("TemporadaModel", "Temporada")
                        .WithOne()
                        .HasForeignKey("InscricaoModel", "TemporadaId");

                    b.Navigation("Categoria");

                    b.Navigation("Divisao");

                    b.Navigation("Piloto");

                    b.Navigation("Temporada");
                });

            modelBuilder.Entity("MelhorVoltaModel", b =>
                {
                    b.HasOne("CalendarioModel", "Calendario")
                        .WithOne()
                        .HasForeignKey("MelhorVoltaModel", "CalendarioId");

                    b.HasOne("ClimaModel", "Clima")
                        .WithOne()
                        .HasForeignKey("MelhorVoltaModel", "ClimaId");

                    b.HasOne("MelhorVoltaDescModel", "MelhorVoltaDesc")
                        .WithOne()
                        .HasForeignKey("MelhorVoltaModel", "MelhorVoltaDescId");

                    b.HasOne("PilotoModel", "Piloto")
                        .WithOne()
                        .HasForeignKey("MelhorVoltaModel", "PilotoId");

                    b.Navigation("Calendario");

                    b.Navigation("Clima");

                    b.Navigation("MelhorVoltaDesc");

                    b.Navigation("Piloto");
                });

            modelBuilder.Entity("PilotoModel", b =>
                {
                    b.HasOne("StatusModel", "Status")
                        .WithOne()
                        .HasForeignKey("PilotoModel", "StatusId");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("PontuacaoModel", b =>
                {
                    b.HasOne("TemporadaModel", "Temporada")
                        .WithOne()
                        .HasForeignKey("PontuacaoModel", "TemporadaId");

                    b.Navigation("Temporada");
                });

            modelBuilder.Entity("PontuacaoPilotoEtapaModel", b =>
                {
                    b.HasOne("CalendarioModel", "Calendario")
                        .WithOne()
                        .HasForeignKey("PontuacaoPilotoEtapaModel", "CalendarioId");

                    b.HasOne("PilotoModel", "Piloto")
                        .WithOne()
                        .HasForeignKey("PontuacaoPilotoEtapaModel", "PilotoId");

                    b.HasOne("PontuacaoModel", "Pontuacao")
                        .WithOne()
                        .HasForeignKey("PontuacaoPilotoEtapaModel", "PontuacaoId");

                    b.Navigation("Calendario");

                    b.Navigation("Piloto");

                    b.Navigation("Pontuacao");
                });

            modelBuilder.Entity("TemporadaModel", b =>
                {
                    b.HasOne("StatusModel", "Status")
                        .WithOne()
                        .HasForeignKey("TemporadaModel", "StatusId");

                    b.Navigation("Status");
                });

            modelBuilder.Entity("TracadoModel", b =>
                {
                    b.HasOne("ClimaModel", "Clima")
                        .WithOne()
                        .HasForeignKey("TracadoModel", "ClimaId");

                    b.HasOne("KartodromoModel", "Kartodromo")
                        .WithOne()
                        .HasForeignKey("TracadoModel", "KartodromoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MelhorVoltaModel", "MvEstreia")
                        .WithOne()
                        .HasForeignKey("TracadoModel", "MvEstreiaId");

                    b.HasOne("MelhorVoltaModel", "MvRecord")
                        .WithOne()
                        .HasForeignKey("TracadoModel", "MvRecordId");

                    b.HasOne("SentidoModel", "Sentido")
                        .WithOne()
                        .HasForeignKey("TracadoModel", "SentidoId");

                    b.Navigation("Clima");

                    b.Navigation("Kartodromo");

                    b.Navigation("MvEstreia");

                    b.Navigation("MvRecord");

                    b.Navigation("Sentido");
                });
#pragma warning restore 612, 618
        }
    }
}

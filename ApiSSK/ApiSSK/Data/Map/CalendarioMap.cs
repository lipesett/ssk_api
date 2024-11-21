using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiSSK.Data.Map
{
    public class CalendarioMap : IEntityTypeConfiguration<CalendarioModel>
    {
        public void Configure(EntityTypeBuilder<CalendarioModel> builder)
        {
            builder.ToTable("CALENDARIO");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("CAL_ID");
            builder.Property(x => x.NomeEtapa).IsRequired().HasMaxLength(100).HasColumnName("CAL_NOME_ETAPA");
            builder.Property(x => x.NumEtapa).IsRequired().HasColumnName("CAL_NUM_ETAPA");
            builder.Property(x => x.Dia).IsRequired().HasColumnName("CAL_DIA");
            builder.Property(x => x.Mes).IsRequired().HasColumnName("CAL_MES");
            builder.Property(x => x.Ano).IsRequired().HasColumnName("CAL_ANO");
            builder.Property(x => x.DataCompleta).IsRequired().HasColumnName("CAL_DATA_COMPLETA");
            builder.Property(x => x.Horario).IsRequired().HasColumnName("CAL_HORARIO");
            builder.Property(x => x.PtsDisputados).IsRequired().HasColumnName("CAL_PTS_DISPUTADOS");
            builder.Property(x => x.EtapaRealizada).IsRequired().HasColumnName("CAL_ETAPA_REALIZADA");
            builder.Property(x => x.TracadoId).HasColumnName("TRA_ID");
            builder.Property(x => x.TemporadaId).HasColumnName("TEM_ID");
            builder.Property(x => x.PilotoId).HasColumnName("PIL_ID");

            builder.HasOne(x => x.Tracado).WithOne().HasForeignKey<CalendarioModel>(x => x.TracadoId);
            builder.HasOne(x => x.Temporada).WithOne().HasForeignKey<CalendarioModel>(x => x.TemporadaId);
            builder.HasOne(x => x.Piloto).WithOne().HasForeignKey<CalendarioModel>(x => x.PilotoId);
        }
    }
}
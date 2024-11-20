using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiSSK.Data.Map
{
    public class CalendarioMap : IEntityTypeConfiguration<CalendarioModel>
    {
        public void Configure(EntityTypeBuilder<CalendarioModel> builder)
        {
            builder.ToTable("CALENDARIO");
            builder.HasKey(x => x.CalId);
            builder.Property(x => x.CalId).HasColumnName("CAL_ID");
            builder.Property(x => x.CalNomeEtapa).IsRequired().HasMaxLength(100).HasColumnName("CAL_NOME_ETAPA");
            builder.Property(x => x.CalNumEtapa).IsRequired().HasColumnName("CAL_NUM_ETAPA");
            builder.Property(x => x.CalDia).IsRequired().HasColumnName("CAL_DIA");
            builder.Property(x => x.CalMes).IsRequired().HasColumnName("CAL_MES");
            builder.Property(x => x.CalAno).IsRequired().HasColumnName("CAL_ANO");
            builder.Property(x => x.CalDataCompleta).IsRequired().HasColumnName("CAL_DATA_COMPLETA");
            builder.Property(x => x.CalHorario).IsRequired().HasColumnName("CAL_HORARIO");
            builder.Property(x => x.CalPtsDisputados).IsRequired().HasColumnName("CAL_PTS_DISPUTADOS");
            builder.Property(x => x.CalEtapaRealizada).IsRequired().HasColumnName("CAL_ETAPA_REALIZADA");
            builder.Property(x => x.TracadoId).HasColumnName("TRA_ID");
            builder.Property(x => x.TemporadaId).IsRequired().HasColumnName("TEM_ID");
            builder.Property(x => x.PilotoId).HasColumnName("PIL_ID");

            builder.HasOne(x => x.Tracado).WithOne().HasForeignKey<CalendarioModel>(x => x.TracadoId);
            builder.HasOne(x => x.Temporada).WithOne().HasForeignKey<CalendarioModel>(x => x.TemporadaId);
            builder.HasOne(x => x.Piloto).WithOne().HasForeignKey<CalendarioModel>(x => x.PilotoId);
        }
    }
}
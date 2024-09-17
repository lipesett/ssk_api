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
            builder.Property(x => x.CalNomeEtapa).HasColumnName("CAL_NOME_ETAPA").IsRequired().HasMaxLength(100);
            builder.Property(x => x.CalNumEtapa).HasColumnName("CAL_NUM_ETAPA").IsRequired();
            builder.Property(x => x.CalDia).HasColumnName("CAL_DIA").IsRequired();
            builder.Property(x => x.CalMes).HasColumnName("CAL_MES").IsRequired();
            builder.Property(x => x.CalAno).HasColumnName("CAL_ANO").IsRequired();
            builder.Property(x => x.CalDataCompleta).HasColumnName("CAL_DATA_COMPLETA").IsRequired();
            builder.Property(x => x.CalHorario).HasColumnName("CAL_HORARIO").IsRequired();
            builder.Property(x => x.CalPtsDisputados).HasColumnName("CAL_PTS_DISPUTADOS").IsRequired();
            builder.Property(x => x.CalEtapaRealizada).HasColumnName("CAL_ETAPA_REALIZADA").IsRequired();
            builder.Property(x => x.TracadoId).HasColumnName("TRA_TRACADO");
            builder.Property(x => x.TemporadaId).HasColumnName("TEM_TEMPORADA").IsRequired();
            builder.Property(x => x.PilotoId).HasColumnName("PIL_PILOTO_VENCEDOR");

            builder.HasOne(x => x.Tracado)
                   .WithOne().HasForeignKey<CalendarioModel>(x => x.TracadoId);
            builder.HasOne(x => x.Temporada)
                   .WithOne().HasForeignKey<CalendarioModel>(x => x.TemporadaId);
            builder.HasOne(x => x.Piloto)
                   .WithOne().HasForeignKey<CalendarioModel>(x => x.PilotoId);
        }
    }
}
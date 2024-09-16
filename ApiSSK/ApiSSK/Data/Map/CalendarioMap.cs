using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiSSK.Data.Map
{
    public class CalendarioMap : IEntityTypeConfiguration<CalendarioModel>
    {
        public void Configure(EntityTypeBuilder<CalendarioModel> builder)
        {
            builder.HasKey(x => x.CalId);
            builder.Property(x => x.CalNomeEtapa).IsRequired().HasMaxLength(255);
            builder.Property(x => x.CalNumEtapa).IsRequired();
            builder.Property(x => x.CalDia).IsRequired();
            builder.Property(x => x.CalMes).IsRequired();
            builder.Property(x => x.CalAno).IsRequired();
            builder.Property(x => x.CalDataCompleta).IsRequired();
            builder.Property(x => x.CalHorario).IsRequired();
            builder.Property(x => x.CalPtsDisputados).IsRequired();
            builder.Property(x => x.CalEtapaRealizada).IsRequired();
            builder.Property(x => x.TracadoId);
            builder.Property(x => x.TemporadaId).IsRequired();
            builder.Property(x => x.PilotoId);

            builder.HasOne(x => x.Tracado);
            builder.HasOne(x => x.Temporada);
            builder.HasOne(x => x.Piloto);
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiSSK.Data.Map
{
    public class MelhorVoltaMap : IEntityTypeConfiguration<MelhorVoltaModel>
    {
        public void Configure(EntityTypeBuilder<MelhorVoltaModel> builder)
        {
            builder.HasKey(x => x.MvId);
            builder.Property(x => x.MvTempo).IsRequired().HasMaxLength(25);
            builder.Property(x => x.MelhorVoltaDescId);
            builder.Property(x => x.PilotoId).IsRequired();
            builder.Property(x => x.ClimaId);
            builder.Property(x => x.CalendarioId);

            builder.HasOne(x => x.MelhorVoltaDesc);
            builder.HasOne(x => x.Piloto);
            builder.HasOne(x => x.Clima);
            builder.HasOne(x => x.Calendario);
        }
    }
}
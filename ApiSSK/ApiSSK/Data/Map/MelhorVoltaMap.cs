using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiSSK.Data.Map
{
    public class MelhorVoltaMap : IEntityTypeConfiguration<MelhorVoltaModel>
    {
        public void Configure(EntityTypeBuilder<MelhorVoltaModel> builder)
        {
            builder.ToTable("MELHOR_VOLTA");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("MV_ID");
            builder.Property(x => x.Tempo).IsRequired().HasMaxLength(25).HasColumnName("MV_TEMPO");
            builder.Property(x => x.MelhorVoltaDescId).HasColumnName("MVD_ID");
            builder.Property(x => x.PilotoId).HasColumnName("PIL_ID");
            builder.Property(x => x.ClimaId).HasColumnName("CLI_ID");
            builder.Property(x => x.CalendarioId).HasColumnName("CAL_ID");

            builder.HasOne(x => x.MelhorVoltaDesc).WithOne().HasForeignKey<MelhorVoltaModel>(x => x.MelhorVoltaDescId);
            builder.HasOne(x => x.Piloto).WithOne().HasForeignKey<MelhorVoltaModel>(x => x.PilotoId);
            builder.HasOne(x => x.Clima).WithOne().HasForeignKey<MelhorVoltaModel>(x => x.ClimaId);
            builder.HasOne(x => x.Calendario).WithOne().HasForeignKey<MelhorVoltaModel>(x => x.CalendarioId);
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiSSK.Data.Map
{
    public class PilotoMap : IEntityTypeConfiguration<PilotoModel>
    {
        public void Configure(EntityTypeBuilder<PilotoModel> builder)
        {
            builder.HasKey(x => x.PilId);
            builder.Property(x => x.PilNome).IsRequired().HasMaxLength(40);
            builder.Property(x => x.PilSobrenome).IsRequired().HasMaxLength(80);
            builder.Property(x => x.PilPodiums).IsRequired();
            builder.Property(x => x.PilCorridasOfc).IsRequired();
            builder.Property(x => x.PilCampeao).IsRequired();
            builder.Property(x => x.PilMelhorChegada).IsRequired();
            builder.Property(x => x.PilUltimaTemp).IsRequired();
            builder.Property(x => x.PilVoltasRapidas).IsRequired();
            builder.Property(x => x.PilPolePosition).IsRequired();
            builder.Property(x => x.PilPeso).IsRequired();
            builder.Property(x => x.PilMelhorQuali).IsRequired();
            builder.Property(x => x.PilLinksFotos).IsRequired().HasMaxLength(1500);
            builder.Property(x => x.StatusId).IsRequired();

            builder.HasOne(x => x.Status);
        }
    }
}
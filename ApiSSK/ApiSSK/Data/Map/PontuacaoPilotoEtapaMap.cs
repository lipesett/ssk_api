using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiSSK.Data.Map
{
    public class PontuacaoPilotoEtapaMap : IEntityTypeConfiguration<PontuacaoPilotoEtapaModel>
    {
        public void Configure(EntityTypeBuilder<PontuacaoPilotoEtapaModel> builder)
        {
            builder.HasKey(x => x.PpeId);
            builder.Property(x => x.PpeTempoMelhorVolta).HasMaxLength(30);
            builder.Property(x => x.MelhorVolta).IsRequired();
            builder.Property(x => x.PilotoId).IsRequired();
            builder.Property(x => x.CalendarioId).IsRequired();
            builder.Property(x => x.PontuacaoId).IsRequired();

            builder.HasOne(x => x.Piloto);
            builder.HasOne(x => x.Calendario);
            builder.HasOne(x => x.Pontuacao);
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiSSK.Data.Map
{
    public class PontuacaoMap : IEntityTypeConfiguration<PontuacaoModel>
    {
        public void Configure(EntityTypeBuilder<PontuacaoModel> builder)
        {
            builder.HasKey(x => x.PonId);
            builder.Property(x => x.PonPosicao).IsRequired();
            builder.Property(x => x.PonPontos).IsRequired();
            builder.Property(x => x.TemporadaId).IsRequired();

            builder.HasOne(x => x.Temporada);
        }
    }
}
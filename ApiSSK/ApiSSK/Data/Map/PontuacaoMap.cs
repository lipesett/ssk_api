using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiSSK.Data.Map
{
    public class PontuacaoMap : IEntityTypeConfiguration<PontuacaoModel>
    {
        public void Configure(EntityTypeBuilder<PontuacaoModel> builder)
        {
            builder.ToTable("PONTUACAO");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("PON_ID");
            builder.Property(x => x.Posicao).IsRequired().HasColumnName("PON_POSICAO");
            builder.Property(x => x.Pontos).IsRequired().HasColumnName("PON_PONTOS");
            builder.Property(x => x.TemporadaId).IsRequired().HasColumnName("TEM_ID");

            builder.HasOne(x => x.Temporada).WithOne().HasForeignKey<PontuacaoModel>(x => x.TemporadaId);
        }
    }
}
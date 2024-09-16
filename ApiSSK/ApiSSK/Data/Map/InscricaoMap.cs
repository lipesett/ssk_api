using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiSSK.Data.Map
{
    public class InscricaoMap : IEntityTypeConfiguration<InscricaoModel>
    {
        public void Configure(EntityTypeBuilder<InscricaoModel> builder)
        {
            builder.HasKey(x => x.InsId);
            builder.Property(x => x.InsDataInscricao).IsRequired();
            builder.Property(x => x.InsPago);
            builder.Property(x => x.TemporadaId).IsRequired();
            builder.Property(x => x.PilotoId).IsRequired();
            builder.Property(x => x.CategoriaId).IsRequired();
            builder.Property(x => x.DivisaoId).IsRequired();

            builder.HasOne(x => x.Temporada);
            builder.HasOne(x => x.Piloto);
            builder.HasOne(x => x.Categoria);
            builder.HasOne(x => x.Divisao);
        }
    }
}
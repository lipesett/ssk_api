using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiSSK.Data.Map
{
    public class KartodromoMap : IEntityTypeConfiguration<KartodromoModel>
    {
        public void Configure(EntityTypeBuilder<KartodromoModel> builder)
        {
            builder.HasKey(x => x.KarId);
            builder.Property(x => x.KarNome).IsRequired().HasMaxLength(50);
            builder.Property(x => x.KarNomCurto).IsRequired().HasMaxLength(25);
            builder.Property(x => x.KarApelido).IsRequired().HasMaxLength(10);
        }
    }
}
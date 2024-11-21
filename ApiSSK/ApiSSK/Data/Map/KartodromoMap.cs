using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiSSK.Data.Map
{
    public class KartodromoMap : IEntityTypeConfiguration<KartodromoModel>
    {
        public void Configure(EntityTypeBuilder<KartodromoModel> builder)
        {
            builder.ToTable("KARTODROMOS");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("KAR_ID");
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(50).HasColumnName("KAR_NOME");
            builder.Property(x => x.NomCurto).IsRequired().HasMaxLength(25).HasColumnName("KAR_NOMCURTO");
            builder.Property(x => x.Apelido).IsRequired().HasMaxLength(10).HasColumnName("KAR_APELIDO");
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiSSK.Data.Map
{
    public class CategoriaMap : IEntityTypeConfiguration<CategoriaModel>
    {
        public void Configure(EntityTypeBuilder<CategoriaModel> builder)
        {
            builder.ToTable("CATEGORIAS");
            builder.HasKey(x => x.CatId);
            builder.Property(x => x.CatId).HasColumnName("CAT_ID");
            builder.Property(x => x.CatNome).HasColumnName("CAT_NOME").IsRequired().HasMaxLength(50);
            builder.Property(x => x.StatusId).HasColumnName("STA_ID").IsRequired();

            builder.HasOne(x => x.Status)
                   .WithOne().HasForeignKey<CategoriaModel>(x => x.StatusId);
        }
    }
}
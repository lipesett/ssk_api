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
            builder.Property(x => x.CatNome).IsRequired().HasMaxLength(50).HasColumnName("CAT_NOME");
            builder.Property(x => x.StatusId).IsRequired().HasColumnName("STA_ID");

            builder.HasOne(x => x.Status).WithOne().HasForeignKey<CategoriaModel>(x => x.StatusId);
        }
    }
}
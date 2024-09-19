using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiSSK.Data.Map
{
    public class CategoriaDivisaoMap : IEntityTypeConfiguration<CategoriaDivisaoModel>
    {
        public void Configure(EntityTypeBuilder<CategoriaDivisaoModel> builder)
        {
            builder.ToTable("CATEGORIA_DIVISAO");
            builder.HasKey(x => new { x.CategoriaId, x.DivisaoId });
            builder.Property(x => x.CategoriaId).HasColumnName("CAT_ID");
            builder.Property(x => x.DivisaoId).HasColumnName("DIV_ID");

            builder.HasOne(x => x.Categoria).WithOne().HasForeignKey<CategoriaDivisaoModel>(x => x.CategoriaId);
            builder.HasOne(x => x.Divisao).WithOne().HasForeignKey<CategoriaDivisaoModel>(x => x.DivisaoId);
        }
    }
}
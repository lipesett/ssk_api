using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiSSK.Data.Map
{
    public class CategoriaDivisaoMap : IEntityTypeConfiguration<CategoriaDivisaoModel>
    {
        public void Configure(EntityTypeBuilder<CategoriaDivisaoModel> builder)
        {
            builder.HasKey(x => x.CategoriaId);
            builder.Property(x => x.DivisaoId).IsRequired();

            builder.HasOne(x => x.Categoria);
            builder.HasOne(x => x.Divisao);
        }
    }
}
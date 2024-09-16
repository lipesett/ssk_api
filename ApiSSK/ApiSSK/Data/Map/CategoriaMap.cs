using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiSSK.Data.Map
{
    public class CategoriaMap : IEntityTypeConfiguration<CategoriaModel>
    {
        public void Configure(EntityTypeBuilder<CategoriaModel> builder)
        {
            builder.HasKey(x => x.CatId);
            builder.Property(x => x.CatNome).IsRequired().HasMaxLength(200);
            builder.Property(x => x.StatusId).IsRequired();

            builder.HasOne(x => x.Status);
        }
    }
}
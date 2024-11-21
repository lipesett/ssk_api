using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiSSK.Data.Map
{
    public class SentidoMap : IEntityTypeConfiguration<SentidoModel>
    {
        public void Configure(EntityTypeBuilder<SentidoModel> builder)
        {
            builder.ToTable("SENTIDO");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("SEN_ID");
            builder.Property(x => x.Descricao).IsRequired().HasMaxLength(30).HasColumnName("SEN_DESCRICAO");
        }
    }
}
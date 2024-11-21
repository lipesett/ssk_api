using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiSSK.Data.Map
{
    public class StatusMap : IEntityTypeConfiguration<StatusModel>
    {
        public void Configure(EntityTypeBuilder<StatusModel> builder)
        {
            builder.ToTable("STATUS");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("STA_ID");
            builder.Property(x => x.Descricao).IsRequired().HasMaxLength(30).HasColumnName("STA_DESCRICAO");
        }
    }
}
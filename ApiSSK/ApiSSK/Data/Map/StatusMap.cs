using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiSSK.Data.Map
{
    public class StatusMap : IEntityTypeConfiguration<StatusModel>
    {
        public void Configure(EntityTypeBuilder<StatusModel> builder)
        {
            builder.ToTable("STATUS");
            builder.HasKey(x => x.StaId);
            builder.Property(x => x.StaId).HasColumnName("STA_ID");
            builder.Property(x => x.StaDesc).HasColumnName("STA_DESC").IsRequired().HasMaxLength(30);
        }
    }
}
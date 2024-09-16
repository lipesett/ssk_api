using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiSSK.Data.Map
{
    public class DivisaoMap : IEntityTypeConfiguration<DivisaoModel>
    {
        public void Configure(EntityTypeBuilder<DivisaoModel> builder)
        {
            builder.HasKey(x => x.DivId);
            builder.Property(x => x.DivNome).IsRequired().HasMaxLength(20);
            builder.Property(x => x.StatusId).IsRequired();

            builder.HasOne(x => x.Status);
        }
    }
}
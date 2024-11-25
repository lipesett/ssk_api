using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiSSK.Data.Map
{
    public class DivisaoMap : IEntityTypeConfiguration<DivisaoModel>
    {
        public void Configure(EntityTypeBuilder<DivisaoModel> builder)
        {
            builder.ToTable("DIVISOES");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("DIV_ID");
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(20).HasColumnName("DIV_NOME");
            builder.Property(x => x.Status).HasColumnName("STATUS").HasColumnType("INT").IsRequired();

            //builder.HasOne(x => x.Status).WithOne().HasForeignKey<DivisaoModel>(x => x.StatusId);
        }
    }
}
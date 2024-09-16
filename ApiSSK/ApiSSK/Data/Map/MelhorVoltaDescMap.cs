using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiSSK.Data.Map
{
    public class MelhorVoltaDescMap : IEntityTypeConfiguration<MelhorVoltaDescModel>
    {
        public void Configure(EntityTypeBuilder<MelhorVoltaDescModel> builder)
        {
            builder.HasKey(x => x.MvdId);
            builder.Property(x => x.MvdDesc).IsRequired().HasMaxLength(25);
        }
    }
}
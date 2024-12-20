﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiSSK.Data.Map
{
    public class CategoriaMap : IEntityTypeConfiguration<CategoriaModel>
    {
        public void Configure(EntityTypeBuilder<CategoriaModel> builder)
        {
            builder.ToTable("CATEGORIAS");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("CAT_ID");
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(50).HasColumnName("CAT_NOME");
            builder.Property(x => x.Status).HasColumnName("STATUS").IsRequired();
        }
    }
}
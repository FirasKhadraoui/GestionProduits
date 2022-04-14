using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Domain.entities;

namespace Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Categorie>
    {
        public void Configure(EntityTypeBuilder<Categorie> builder)
        {
            builder.ToTable("MyCategories");
            builder.HasKey(e => e.CategorieId);
            builder.Property(p => p.name).IsRequired().HasMaxLength(50);

        }

    }
}

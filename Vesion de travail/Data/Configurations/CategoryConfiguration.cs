using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("MyCategories");
            builder.HasKey(c => c.CategoryId);
            builder.Property(c => c.Name).HasMaxLength(50).IsRequired();
        }
    }
}

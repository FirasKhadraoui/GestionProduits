using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;

namespace Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasMany(p => p.Providers).WithMany(pr => pr.Products).UsingEntity(i=>i.ToTable("Providings"));
            builder.HasOne(p => p.MyCategory).WithMany(c => c.Products).HasForeignKey(p => p.CategoryId).OnDelete(DeleteBehavior.Restrict);
            builder.HasDiscriminator<int>("isBiological").HasValue<Product>(0).HasValue<Biological>(1).HasValue<Chemical>(2);
        }
    }
}

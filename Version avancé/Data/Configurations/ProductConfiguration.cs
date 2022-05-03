using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Domain.entities;

namespace Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasMany(p => p.Providers).WithMany(pr => pr.products).UsingEntity(i => i.ToTable("Providings")); //table d'association 
            builder.HasOne(s => s.categorie).WithMany(g => g.products).HasForeignKey(s => s.CategoryId).OnDelete(DeleteBehavior.Restrict);
            builder.HasDiscriminator<int>("IsBiological").HasValue<Product>(0).HasValue<Biological>(1).HasValue<Chemical>(2);
            builder.Property(p => p.Description).HasMaxLength(200).IsRequired(false);// is required false bech ngoul eli champs heka peut etre null

         

        }

    }
}

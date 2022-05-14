using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;

namespace Data.Configurations
{
    public class FactureConfiguration : IEntityTypeConfiguration<Facture>
    {
        public void Configure(EntityTypeBuilder<Facture> builder)
        {
            builder.HasKey(f => new
            {
                f.ProductFk,
                f.ClientFk,
                f.DateAchat
            });
            builder.HasOne(f => f.product).WithMany(prod => prod.Factures).HasForeignKey(f => f.ProductFk);
            builder.HasOne(f => f.client).WithMany(cl => cl.Factures).HasForeignKey(f => f.ClientFk);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Domain.entities;

namespace Data.Configurations
{
    class FactureConfiguration : IEntityTypeConfiguration<Facture>
    {
        public void Configure(EntityTypeBuilder<Facture> builder)
        {
            builder.HasKey(fp => new { fp.clientFK, fp.productFK  ,fp.date_achat });
            builder.HasOne(f => f.product).WithMany(p => p.factures).HasForeignKey(f => f.productFK);
            builder.HasOne(f => f.client).WithMany(c => c.factures).HasForeignKey(f => f.clientFK);

            


            //builder.HasOne(fp=>fp.clientFK)
        }
    }
}

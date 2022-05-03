using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Domain.entities;

namespace Data.Configurations
{
    public class ChemicalConfiguration : IEntityTypeConfiguration<Chemical>
    {
        public void Configure(EntityTypeBuilder<Chemical> builder)
        {
            builder.OwnsOne(c => c.MyAdress, myadd => { 
                
                myadd.Property(a => a.StreetAdress).HasMaxLength(50).HasColumnName("MyStreet");
                myadd.Property(c => c.City).HasColumnName("MyCity").IsRequired();

            });
            

           
        }
    }
}

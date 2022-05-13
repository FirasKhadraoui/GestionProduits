using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Data.Configurations
{
    public class ChemicalConfiguration : IEntityTypeConfiguration<Chemical>
    {
        public void Configure(EntityTypeBuilder<Chemical> builder)
        {
            builder.OwnsOne(c => c.Myadress, MyAdd =>
               {
                   MyAdd.Property(c => c.StreetAdress).HasMaxLength(50).HasColumnName("MyStreet");
                   MyAdd.Property(c => c.City).IsRequired().HasColumnName("MyCity");
               });
        }
    }
}

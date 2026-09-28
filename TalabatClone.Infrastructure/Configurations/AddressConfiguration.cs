using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TalabatClone.Domain.Entities;

namespace TalabatClone.Infrastructure.Configurations
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.Property(builder => builder.City).HasMaxLength(100);
            builder.Property(builder => builder.Country).HasMaxLength(100);
            builder.Property(builder => builder.Street).HasMaxLength(100);
            builder.Property(builder => builder.ZipCode).HasMaxLength(20);
        }
    }
}

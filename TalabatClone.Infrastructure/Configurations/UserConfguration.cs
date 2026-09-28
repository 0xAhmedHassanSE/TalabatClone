using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TalabatClone.Domain.Entities;

namespace TalabatClone.Infrastructure.Configurations
{
    public class UserConfguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(user => user.FirstName).HasMaxLength(100);
            builder.Property(user => user.LastName).HasMaxLength(100);
        }
    }
}

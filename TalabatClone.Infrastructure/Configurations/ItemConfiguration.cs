using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TalabatClone.Domain.Entities;

namespace TalabatClone.Infrastructure.Configurations
{
    public class ItemConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.Property(item => item.Name).HasMaxLength(100);
            builder.Property(item => item.Description).HasMaxLength(400);
            builder.Property(item => item.Price).HasPrecision(8,2);

        }
    }
}

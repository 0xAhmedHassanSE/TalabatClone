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
            builder.Property(item => item.Price).HasPrecision(8, 2);
            builder.HasMany(i => i.CartItems).WithOne(ci => ci.Item)
                .HasForeignKey(ci => ci.ItemId).OnDelete(DeleteBehavior.Restrict);
            builder.HasQueryFilter(i => !i.IsDeleted);

        }
    }
}

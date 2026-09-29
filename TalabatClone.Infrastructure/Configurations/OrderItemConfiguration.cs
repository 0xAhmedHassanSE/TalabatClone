using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TalabatClone.Domain.Entities;

public class OrderItemConfiguration : IEntityTypeConfiguration<OrderItem>
{
    public void Configure(EntityTypeBuilder<OrderItem> builder)
    {
        builder.Property(oi => oi.UnitOfPrice).HasPrecision(12, 2);
        builder.HasOne(oi => oi.Item).WithMany(i => i.OrderItems)
            .HasForeignKey(oi => oi.ItemId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(oi => oi.Order).WithMany(o => o.OrderItems)
          .HasForeignKey(oi => oi.OrderId).OnDelete(DeleteBehavior.Restrict);
    }
}
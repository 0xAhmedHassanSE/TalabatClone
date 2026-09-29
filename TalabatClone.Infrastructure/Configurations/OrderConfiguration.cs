using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TalabatClone.Domain.Entities;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.Property(o => o.Status).HasConversion<string>().HasMaxLength(100);
        builder.Property(o => o.OrderAmount).HasPrecision(12, 2);
        builder.HasOne(o => o.OrderGroup).WithMany(o => o.Orders).
            HasForeignKey(o => o.OrderGroupId).OnDelete(DeleteBehavior.Restrict);
    }
}
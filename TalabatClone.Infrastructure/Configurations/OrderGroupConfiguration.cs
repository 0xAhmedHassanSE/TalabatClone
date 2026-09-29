using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TalabatClone.Domain.Entities;

public class OrderGroupConfiguration : IEntityTypeConfiguration<OrderGroup>
{
    public void Configure(EntityTypeBuilder<OrderGroup> builder)
    {
        builder.HasOne(OG => OG.Rider).WithMany(rider => rider.OrdersDelivery).HasForeignKey(og => og.RiderId);
        builder.HasOne(og => og.Customer).WithMany(customer => customer.OrdersRequested).HasForeignKey(og => og.CustomerId);
        builder.Property(og => og.Amount).HasPrecision(12, 2);
    }
}
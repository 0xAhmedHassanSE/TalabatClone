using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TalabatClone.Domain.Entities;

public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
{
    public void Configure(EntityTypeBuilder<Payment> builder)
    {
        builder.HasOne(pay => pay.OrderGroup).WithOne(og => og.Payment).HasForeignKey<Payment>(pay => pay.OrderGroupId).OnDelete(DeleteBehavior.Restrict);
        builder.Property(pay => pay.Amount).HasPrecision(12, 2);
        builder.Property(pay => pay.PaymentStatus).HasConversion<string>().HasMaxLength(100);
        builder.Property(pay => pay.PaymentMethod).HasConversion<string>().HasMaxLength(100);
        builder.HasQueryFilter(p => !p.IsDeleted);


    }
}
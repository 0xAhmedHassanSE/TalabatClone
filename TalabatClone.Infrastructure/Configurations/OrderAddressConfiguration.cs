using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TalabatClone.Domain.Entities;

namespace TalabatClone.Infrastructure.Configurations
{
    public class OrderAddressConfiguration : IEntityTypeConfiguration<OrderAddress>
    {
        public void Configure(EntityTypeBuilder<OrderAddress> builder)
        {
            builder.ComplexProperty(o => o.Address);
            builder.HasOne(oa => oa.OrderGroup).WithOne(og => og.CustomerAddress).HasForeignKey<OrderAddress>(oa => oa.OrderGroupId);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TalabatClone.Domain.Entities;

namespace TalabatClone.Infrastructure.Configurations
{
    public class UserConfguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(user => user.FirstName).HasMaxLength(100);
            builder.Property(user => user.LastName).HasMaxLength(100);
            builder.ComplexProperty(user => user.Address);
            builder.HasMany(c => c.Carts).WithOne(cart => cart.Customer).HasForeignKey(cart => cart.CustomerId);
            builder.HasQueryFilter(user => !user.IsDeleted);

        }
    }
}

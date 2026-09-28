
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TalabatClone.Domain.Entities;

namespace TalabatClone.Infrastructure.Configurations
{
    public class RestaurantConfiguration : IEntityTypeConfiguration<Restaurant>
    {
        public void Configure(EntityTypeBuilder<Restaurant> builder)
        {
            builder.Property(R => R.Status).HasConversion<string>();
            builder.Property(r => r.Name).HasMaxLength(100);
            builder.Property(r => r.City).HasMaxLength(100);
            builder.Property(r => r.Country).HasMaxLength(100);
            builder.Property(r => r.Status).HasMaxLength(30);
            builder.Property(r => r.Street).HasMaxLength(100);
            builder.Property(r => r.ZipCode).HasMaxLength(20);
            builder.HasOne(R => R.Owner).WithMany(owner => owner.Restaurants).HasForeignKey(r => r.OwnerId).OnDelete(DeleteBehavior.Restrict);

        }
    }
}

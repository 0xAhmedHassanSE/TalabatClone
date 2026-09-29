
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TalabatClone.Domain.Entities;
using TalabatClone.Infrastructure.Configurations;

namespace TalabatClone.Infrastructure.Database
{
    public class TalabatDB:IdentityDbContext<User>
    {
        public TalabatDB(DbContextOptions<TalabatDB> optionsBuilder):base(optionsBuilder)
        {
           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TalabatDB).Assembly);
        }
        public virtual DbSet<Restaurant>Restaurants { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderGroup> OrderGroups { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }
        public virtual DbSet<OrderAddress> OrderAddresses { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<CartItem> CartItems { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }



    }
}


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
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }


    }
}

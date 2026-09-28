
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TalabatClone.Domain.Entities;

namespace TalabatClone.Infrastructure.Database
{
    public class TalabatDB:IdentityDbContext
    {
        public TalabatDB(DbContextOptions<DbContext> optionsBuilder):base(optionsBuilder)
        {
           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public virtual DbSet<Restaurant>Restaurants { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Category> Categories { get; set; }


    }
}

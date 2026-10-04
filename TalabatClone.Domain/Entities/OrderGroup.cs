
namespace TalabatClone.Domain.Entities
{
    public class OrderGroup : ISoftDeleted
    {
        public int Id { get; set; }
        public string CustomerId { get; set; } = null!;
        public virtual User Customer { get; set; } = null!;
        public string? RiderId { get; set; }
        public virtual User? Rider { get; set; }
        public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
        public virtual OrderAddress CustomerAddress { get; set; } = null!;
        public decimal Amount { get; set; }
        public virtual Payment Payment { get; set; } = null!;
        public bool IsDeleted { get; set; }



    }
}

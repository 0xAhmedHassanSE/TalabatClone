
using TalabatClone.Domain.Enums;

namespace TalabatClone.Domain.Entities
{
    public class Order:ISoftDeleted
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public OrderStatus Status { get; set; }
        public int RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; } = null!;
        public virtual ICollection<OrderItem>? OrderItems { get; set; } = new List<OrderItem>();
        public int OrderGroupId { get; set; }
        public virtual OrderGroup OrderGroup { get; set; } = null!;
        public decimal OrderAmount { get; set; }
        public bool IsDeleted { get; set; }

    }
}

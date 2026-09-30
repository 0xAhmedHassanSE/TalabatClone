
namespace TalabatClone.Domain.Entities
{
    public class Item:ISoftDeleted
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; } = null!;
        public virtual ICollection<CartItem>? CartItems { get; set; } = new List<CartItem>();
        public virtual ICollection<OrderItem>? OrderItems { get; set; } = new List<OrderItem>();
        public bool IsDeleted { get; set; }

    }
}

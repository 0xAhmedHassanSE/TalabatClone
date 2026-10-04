
namespace TalabatClone.Domain.Entities
{
    public class Cart
    {
        public int Id { get; set; }
        public string CustomerId { get; set; } = string.Empty;
        public virtual User Customer { get; set; } = null!;
        public int RestaurantId { get; set; }
        public virtual Restaurant Restaurant { get; set; } = null!;
        public virtual ICollection<CartItem>? CartItems { get; set; } = new List<CartItem>();


    }
}

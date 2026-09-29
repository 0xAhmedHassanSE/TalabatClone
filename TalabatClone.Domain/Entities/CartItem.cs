

namespace TalabatClone.Domain.Entities
{
    public class CartItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int CartId { get; set; }
        public int ItemId { get; set; }
        public virtual Cart Cart { get; set; } = null!;
        public virtual Item Item { get; set; } = null!;
    }
}

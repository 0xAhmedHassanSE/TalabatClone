
namespace TalabatClone.Domain.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int OrderId { get; set; }
        public  int Quantity { get; set; }
        public decimal UnitOfPrice { get; set; }
        public virtual Order Order { get; set; } = null!;
        public virtual Item Item { get; set; } = null!;
    }
}

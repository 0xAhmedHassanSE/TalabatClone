
using TalabatClone.Domain.Enums;

namespace TalabatClone.Domain.Entities
{
    public class Restaurant:ISoftDeleted
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public Address Address { get; set; } = null!;
        public string OwnerId { get; set; } = string.Empty;
        public RestaurantStatus Status { get; set; } = RestaurantStatus.Opened;
        public virtual ICollection<Category>? Categories { get; set; } = new List<Category>();
        public virtual ICollection<Cart>? Carts { get; set; } = new List<Cart>();
        public virtual ICollection<Order>? Orders { get; set; } = new List<Order>();
        public virtual User Owner { get; set; } = null!;
        public bool IsDeleted { get; set; }
    }
}

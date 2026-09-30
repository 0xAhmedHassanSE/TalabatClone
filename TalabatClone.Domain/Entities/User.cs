using Microsoft.AspNetCore.Identity;


namespace TalabatClone.Domain.Entities
{
    public class User:IdentityUser,ISoftDeleted
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public Address Address { get; set; } = null!;
        public virtual ICollection<Restaurant>? Restaurants { get; set; } = new List<Restaurant>();//Owner
        public virtual ICollection<Cart>? Carts { get; set; } = new List<Cart>();//Customer
        public virtual ICollection<OrderGroup>? OrdersRequested { get; set; } = new List<OrderGroup>();//Customer
        public virtual ICollection<OrderGroup>? OrdersDelivery { get; set; } = new List<OrderGroup>();//Rider
        public bool IsDeleted { get; set; } = false; // soft delete

    }
}

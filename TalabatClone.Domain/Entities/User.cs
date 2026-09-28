using Microsoft.AspNetCore.Identity;


namespace TalabatClone.Domain.Entities
{
    public class User:IdentityUser
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();
        public virtual ICollection<Restaurant> Restaurants { get; set; } = new List<Restaurant>();

    }
}


using TalabatClone.Domain.Enums;

namespace TalabatClone.Domain.Entities
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public string OwnerId { get; set; } = string.Empty;
        public RestaurantStatus Status { get; set; } = RestaurantStatus.Opened;
        public virtual ICollection<Category>? Categories { get; set; } = new List<Category>();
        public virtual User Owner { get; set; } = null!;
    }
}

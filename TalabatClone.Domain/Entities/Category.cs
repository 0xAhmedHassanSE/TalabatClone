namespace TalabatClone.Domain.Entities
{
    public class Category:ISoftDeleted
    {
        public int Id { get; set; }
        public int RestaurantId { get; set; }
        public string Name { get; set; } = string.Empty!;
        public string? Description { get; set; }
        public virtual Restaurant Restaurant { get; set; } = null!;
        public virtual ICollection<Item>? Items { get; set; }
        public bool IsDeleted { get; set; }

    }
}

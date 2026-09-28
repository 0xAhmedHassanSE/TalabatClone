
namespace TalabatClone.Domain.Entities
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int Category_Id { get; set; }
        public virtual Category Category { get; set; }
        
    }
}

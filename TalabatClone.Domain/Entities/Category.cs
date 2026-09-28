namespace TalabatClone.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public int Restaurant_Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public virtual ICollection<Item> Items{ get; set; }
    }
}

//Dpendant Entity on OrderGroup 1 to 1 Relashionship

namespace TalabatClone.Domain.Entities
{
    public class OrderAddress
    {
        public int Id { get; set; }
        public int OrderGroupId { get; set; }
        public virtual OrderGroup OrderGroup { get; set; } = null!;
        public Address Address { get; set; } = null!;

    }
}

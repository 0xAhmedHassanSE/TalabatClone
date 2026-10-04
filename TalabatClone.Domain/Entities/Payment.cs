

using TalabatClone.Domain.Enums;

namespace TalabatClone.Domain.Entities
{
    public class Payment : ISoftDeleted
    {
        public int Id { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public PaymentStatus PaymentStatus { get; set; }
        public decimal Amount { get; set; }
        public DateTime PaymentDate { get; set; } = DateTime.Now;
        public int OrderGroupId { get; set; }
        public virtual OrderGroup OrderGroup { get; set; } = null!;
        public bool IsDeleted { get; set; }
    }
}

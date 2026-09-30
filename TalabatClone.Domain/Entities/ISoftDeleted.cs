

namespace TalabatClone.Domain.Entities
{
    public interface ISoftDeleted
    {
        bool IsDeleted { get; set; }
    }
}

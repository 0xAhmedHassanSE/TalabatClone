
namespace TalabatClone.Application.Interfaces.Repos
{
    public interface IGenericRepo<T> where T : class
    {
        Task AddAsync(T item);
        void Update(T item);
        Task<T?> GetByIDAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        void Delete(T item);
    }
}



using TalabatClone.Domain.Entities;

namespace TalabatClone.Application.Interfaces.Repos
{
    public interface IUserRepo
    {
        Task AddAsync(User user);
        void Update(User user);
        Task<User> GetByIDAsync(string id);
        Task<IEnumerable<User>> GetAllAsync(User user);
        void Delete(string id);
    }
}

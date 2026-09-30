

using Microsoft.EntityFrameworkCore;
using TalabatClone.Application.Interfaces.Repos;
using TalabatClone.Domain.Entities;
using TalabatClone.Infrastructure.Database;

namespace TalabatClone.Infrastructure.Implementations.Repos
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class
    {
        private readonly TalabatDB talabatDB;
        public GenericRepo(TalabatDB talabatDB)
        {
            this.talabatDB = talabatDB;
        }
        public async Task AddAsync(T item) => await talabatDB.Set<T>().AddAsync(item);


        public void Delete(T item) {
            if (item is ISoftDeleted softDeleted)
                softDeleted.IsDeleted = true;
            else
            talabatDB.Set<T>().Remove(item);
        }


        public async Task<IEnumerable<T>> GetAllAsync() => await talabatDB.Set<T>().AsNoTracking().ToListAsync();


        public async Task<T?> GetByIDAsync(int id) => await talabatDB.Set<T>().FindAsync(id);


        public void Update(T item) => talabatDB.Set<T>().Update(item);

    }
}

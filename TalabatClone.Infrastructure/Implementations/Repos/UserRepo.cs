
using Microsoft.EntityFrameworkCore;
using TalabatClone.Application.Interfaces.Repos;
using TalabatClone.Domain.Entities;
using TalabatClone.Infrastructure.Database;

namespace TalabatClone.Infrastructure.Implementations.Repos
{
    public class UserRepo : IUserRepo
    {
        private readonly TalabatDB talabatDB;
        public UserRepo(TalabatDB talabatDB) => this.talabatDB = talabatDB;

        public async Task AddAsync(User user) => await talabatDB.Users.AddAsync(user);


        public void Delete(User user) => user.IsDeleted = true;


        public async Task<IEnumerable<User>> GetAllAsync() => await talabatDB.Users.AsNoTracking().ToListAsync();


        public async Task<User?> GetByIDAsync(string id) => await talabatDB.Users.FindAsync(id);


        public void Update(User user) => talabatDB.Users.Update(user);

    }
}

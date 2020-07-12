using System.Threading.Tasks;
using ComplexControllers.Application.Interfaces;
using ComplexControllers.Domain;
using Microsoft.EntityFrameworkCore;

namespace ComplexControllers.DataLayer.Repositories {
    public class UserRepository : IUserRepository {
        private readonly DataStore dataStore;

        public UserRepository(DataStore dataStore) {
            this.dataStore = dataStore;
        }

        public async Task<User[]> GetUsersAsync() => await dataStore.Users
            .Include(user => user.Articles)
            .ToArrayAsync();
    }
}
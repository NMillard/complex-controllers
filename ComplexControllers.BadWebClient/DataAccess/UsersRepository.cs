using System.Threading.Tasks;
using ComplexControllers.BadWebClient.Models;

namespace ComplexControllers.BadWebClient.DataAccess {
    public class UsersRepository : IUserRepository {
        public async Task<User[]> GetUsersAsync() {
            return new User[] {
                new User("Bobby G"), 
                new User("Thomas H"), 
            };
        }
    }
}
using System.Threading.Tasks;
using ComplexControllers.BadWebClient.Models;

namespace ComplexControllers.BadWebClient.DataAccess {
    public interface IUserRepository {
        Task<User[]> GetUsersAsync();
    }
}
using System.Threading.Tasks;
using ComplexControllers.Domain;

namespace ComplexControllers.Application.Interfaces {
    public interface IUserRepository {
        Task<User[]> GetUsersAsync();
    }
}
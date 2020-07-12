using System.Collections.Generic;
using System.Threading.Tasks;
using ComplexControllers.Application.Interfaces;
using ComplexControllers.Domain;

namespace ComplexControllers.Application.Queries {
    public class GetUsers {
        private readonly IUserRepository repository;

        public GetUsers(IUserRepository repository) {
            this.repository = repository;
        }
        
        public async Task<IEnumerable<User>> ExecuteAsync() =>
            await repository.GetUsersAsync();
    }
}
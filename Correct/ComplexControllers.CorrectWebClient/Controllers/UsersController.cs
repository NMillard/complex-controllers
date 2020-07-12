using System.Threading.Tasks;
using ComplexControllers.Application.Queries;
using Microsoft.AspNetCore.Mvc;

namespace ComplexControllers.CorrectWebClient.Controllers {
    
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase {
        private readonly GetUsers getUsers;

        public UsersController(GetUsers getUsers) {
            this.getUsers = getUsers;
        }

        [HttpGet]
        public async Task<IActionResult> Get() => Ok(await getUsers.ExecuteAsync());
    }
}
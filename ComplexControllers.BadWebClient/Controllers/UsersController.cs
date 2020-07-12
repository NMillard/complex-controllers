using System.Collections.Generic;
using System.Threading.Tasks;
using ComplexControllers.BadWebClient.DataAccess;
using ComplexControllers.BadWebClient.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ComplexControllers.BadWebClient.Controllers {
    
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase {
        private readonly DataStore dataStore;

        public UsersController(DataStore dataStore) {
            this.dataStore = dataStore;
        }

        [HttpGet]
        public async Task<IActionResult> Get() {
            IEnumerable<User> users = await dataStore
                .Users
                .Include(user => user.Articles)
                .ToListAsync();
            
            return Ok(users);
        }
    }
}
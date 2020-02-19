using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TriageApp.API.Data;
using TriageApp.API.Models;

namespace TriageApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _repository;
        public AuthController(IAuthRepository repository)
        {
            _repository = repository;

        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(string username, string password)
        {
            username = username.ToLower();

            if (await _repository.UserExists(username))
                return BadRequest("User already exists");

            var userToCreate = new User
            {
                Username = username
            };

            var createdUser = await _repository.Register(userToCreate, password);

            return StatusCode(201);
        }
    }
}
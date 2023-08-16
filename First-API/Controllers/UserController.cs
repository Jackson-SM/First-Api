using First_API.Models;
using First_API.Repositories.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace First_API.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public async  Task<ActionResult<List<User>>> GetAllUsers()
        {
            List<User> users =  await _userRepository.GetAllUsers();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetById(Guid id)
        {
            User user = await _userRepository.GetById(id);

            return Ok(user);
        }

        [HttpPost]
        public async Task<ActionResult<User>> Create([FromBody] User user)
        {
            User userCreated = await _userRepository.Create(user);
            return Ok(userCreated);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            await _userRepository.Delete(id);
            return Ok();
        }

        [HttpPatch]
        public async Task<ActionResult<User>> Update([FromBody] User user)
        {
            User userUpdate = await _userRepository.Update(user);

            return Ok(userUpdate);
        }
    }
}

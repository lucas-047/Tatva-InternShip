using Microsoft.AspNetCore.Mvc;
using Test.Data.Repositories.IRepository;
using Test.Models;

namespace Test.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet("all-in-memory")]
        public ActionResult<List<User>> GetAllUsersInMemory()
        {
            return _userRepository.GetAllUsersInMemory();
        }

        [HttpGet("all-from-database")]
        public ActionResult<List<User>> GetAllUsersFromDatabase()
        {
            return _userRepository.GetAllUsersFromDatabase();
        }

        [HttpGet("find-user/{id}")]
        public ActionResult<User> GetUserById(int id)
        {
            var user = _userRepository.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }
            return user;
        }
        [HttpGet("find-role/{id}")]
        public ActionResult<Role> GetRoleById(int id)
        {
            var role = _userRepository.GetRoleById(id);
            if (role == null)
            {
                return NotFound();
            }
            return role;
        }

        [HttpPost("add-user")]
        public IActionResult AddUser(User user)
        {
            _userRepository.AddUser(user);
            return CreatedAtAction(nameof(GetUserById), new { id = user.UserId }, user);
        }

       [HttpPost("add-role")]
        public IActionResult AddRole(Role role)
        {
            _userRepository.AddRole(role);
            return CreatedAtAction(nameof(GetRoleById), new { id = role.RoleId }, role);
        }

        [HttpGet("ordered-by-username")]
        public ActionResult<List<User>> GetUsersOrderedByUsername()
        {
            return _userRepository.GetUsersOrderedByUsername();
        }

        [HttpGet("grouped-by-role")]
        public ActionResult<List<IGrouping<string, User>>> GetUsersGroupedByRole()
        {
            return _userRepository.GetUsersGroupedByRole();
        }

        [HttpGet("user-with-roles")]
        public ActionResult<List<UserRoleDto>> GetUsersWithRoles()
        {
            return _userRepository.GetUsersWithRoles();
        }

        /*[HttpPost]
        public IActionResult AddUsers([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest();
            }
            var role = _userRepository.GetRoleById(user.RoleId);
            if (role == null)
            {
                return BadRequest("Invalid Role ID");
            }
            user.Role = role;

            _userRepository.AddUser(user);
            return CreatedAtAction(nameof(GetUserById), new { id = user.UserId }, user);

        }*/
    }
}

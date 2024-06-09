using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Test.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthTestController : ControllerBase
    {
        [HttpGet("admin")]
        [Authorize(Policy = "Admin")]
        public IActionResult GetAdminValue()
        {
            return Ok("You Enter in Admin Place");
        }
        [HttpGet("user")]
        [Authorize(Policy = "User")]
        public IActionResult GetUserValue()
        {
            return Ok("You Enter in User Place");
        }
        [HttpGet("all")]
        [Authorize]
        public IActionResult GetAll()
        {
            return Ok("This Place is Open for Everyone");
        }
    }
}

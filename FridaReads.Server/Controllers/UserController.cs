using FridaReads.Server.BusinessLogics;
using FridaReads.Server.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FridaReads.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly UserBusinessLogic _userBusinessLogic;

        public UserController(UserBusinessLogic userBusinessLogic)
        {
            _userBusinessLogic = userBusinessLogic;
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddUser([FromBody] UserModel userModel)
        {
            try
            {
                var addedUser = await _userBusinessLogic.AddUser(userModel);
                return Ok(addedUser);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPut]
        [Authorize(Policy = "AdminOnly")]
        public async Task<IActionResult> UpdateUser([FromBody] UserModel userModel)
        {
            var user = await _userBusinessLogic.UpdateUser(userModel);
            return Ok(user);
        }

        [HttpDelete]
        [Authorize(Policy = "AdminOnly")]
        public async Task<IActionResult> DeleteUser([FromBody] UserModel userModel)
        {
            await _userBusinessLogic.DeleteUser(userModel);
            return NoContent();
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = await _userBusinessLogic.GetUserById(id);
            return Ok(user);
        }

        [HttpGet]
        [Authorize(Policy = "AdminOnly")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _userBusinessLogic.GetAllUsers();
            return Ok(users);
        }
    }
}

using FridaReads.Server.BusinessLogics;
using FridaReads.Server.Models;
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
    }
}

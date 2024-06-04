using FridaReads.Server.BusinessLogics;
using FridaReads.Server.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FridaReads.Server.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class TextController : Controller
    {
        private readonly TextBusinessLogic _textBusinessLogic;

        public TextController(TextBusinessLogic textBusinessLogic)
        {
            _textBusinessLogic = textBusinessLogic;
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddText([FromBody] TextModel textModel)
        {
            try
            {
                var addedText = await _textBusinessLogic.AddText(textModel);
                return Ok(addedText);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateText([FromBody] TextModel textModel)
        {
            var text = await _textBusinessLogic.UpdateTextReview(textModel);
            return Ok(text);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteText([FromBody] TextModel textModel)
        {
            await _textBusinessLogic.DeleteTextReview(textModel);
            return NoContent();
        }

        [HttpGet("email/{email}")]
        [Authorize]
        public async Task<IActionResult> GetTextsByUser(string email)
        {
            var text = await _textBusinessLogic.GetTextByUser(email);
            return Ok(text);
        }
        
        [HttpGet("user/{id}")]
        [Authorize]
        public async Task<IActionResult> GetTextsByUser(int id)
        {
            var text = await _textBusinessLogic.GetTextByUserId(id);
            return Ok(text);
        }

        [HttpGet]
        [Authorize(Policy = "AdminOnly")]
        public async Task<IActionResult> GetAllTexts()
        {
            var texts = await _textBusinessLogic.GetAllTexts();
            return Ok(texts);
        }
    }
}

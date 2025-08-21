using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("Div")]
        public IActionResult GetDiv([FromQuery] int a, [FromQuery] int b)
        {
            int result = a / b; // o: var result = a - b;
            return Ok(new { a, b, result });
        }
    }
}
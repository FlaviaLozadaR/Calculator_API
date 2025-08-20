using Microsoft.AspNetCore.Mvc;

namespace Calculator_API.Controllers;

public class CalculatorController
{
    [Route(routeTemplate: "api/[controller]")]
    [ApiController]
    public class calculatorController : ControllerBase
    {
        {
            [HttpGet("sum")]
            public IActionResult Sum([FromQuery] int a, [FromQuery] int b)
            {
                int resultado = a + b;
                return Ok(new { resultado });
            }
        }
    }
}
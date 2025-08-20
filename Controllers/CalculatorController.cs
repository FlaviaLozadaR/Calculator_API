using Microsoft.AspNetCore.Mvc;

namespace Calculator_API.Controllers;

public class CalculatorController
{
    [Route(routeTemplate: "api/[controller]")]
    [ApiController]
    public class calculatorController : ControllerBase
}
using Microsoft.AspNetCore.Mvc;
using ScientificCalculatorApi.Services;

namespace ScientificCalculatorApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculatorService _calculatorService;

        public CalculatorController(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        [HttpGet("add")]
        public IActionResult Add(double a, double b) => Ok(_calculatorService.Add(a, b));

        [HttpGet("subtract")]
        public IActionResult Subtract(double a, double b) => Ok(_calculatorService.Subtract(a, b));

        [HttpGet("multiply")]
        public IActionResult Multiply(double a, double b) => Ok(_calculatorService.Multiply(a, b));

        [HttpGet("divide")]
        public IActionResult Divide(double a, double b) => Ok(_calculatorService.Divide(a, b));

        [HttpGet("sqrt")]
        public IActionResult SquareRoot(double a) => Ok(_calculatorService.SquareRoot(a));

        [HttpGet("exponent")]
        public IActionResult Exponent(double baseValue, double exponent) => Ok(_calculatorService.Exponent(baseValue, exponent));

        [HttpGet("percentage")]
        public IActionResult Percentage(double value, double total) => Ok(_calculatorService.Percentage(value, total));

        [HttpGet("modulus")]
        public IActionResult Modulus(double a, double b) => Ok(_calculatorService.Modulus(a, b));

        [HttpGet("factorial")]
        public IActionResult Factorial(int number) => Ok(_calculatorService.Factorial(number));

        [HttpGet("cube-root")]
        public IActionResult CubeRoot(double a) => Ok(_calculatorService.CubeRoot(a));
    }

}

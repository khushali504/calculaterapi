using Microsoft.AspNetCore.Mvc;

namespace CalculatorApi.Controllers
{
    [ApiController]
    [Route("calculator")]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("add")]
        public ActionResult<decimal> Add(decimal a, decimal b)
        {
            return a + b;
        }

        [HttpGet("subtract")]
        public ActionResult<decimal> Subtract(decimal a, decimal b)
        {
            return a - b;
        }

        [HttpGet("multiply")]
        public ActionResult<decimal> Multiply(decimal a, decimal b)
        {
            return a * b;
        }

        [HttpGet("divide")]
        public ActionResult<decimal> Divide(decimal a, decimal b)
        {
            if (b == 0) 
                return BadRequest("Cannot divide by zero");
            return a / b;
        }

        [HttpGet("modulo")]
        public ActionResult<decimal> Modulo(decimal a, decimal b)
        {
            if (b == 0)
                return BadRequest("Cannot modulo by zero");
            return a % b;
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace SubtractionService.Controllers
{
    [Route("SubtractService")]
    public class SubtractController : Controller
    {
        [Route("Subtract")]
        public IActionResult Get([FromQuery] int n1, [FromQuery] int n2)
        {
            return Content((n1 - n2).ToString());
        }
    }
}

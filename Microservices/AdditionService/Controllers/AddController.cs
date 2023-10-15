using Microsoft.AspNetCore.Mvc;

namespace AdditionService.Controllers
{
    [Route("AddService")]
    public class AddController : Controller
    {
        [Route("Add")]
        public IActionResult Get([FromQuery] int n1, [FromQuery] int n2)
        {
            return Content((n1+n2).ToString());
        }
    }
}

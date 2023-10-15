using Microsoft.AspNetCore.Mvc;

namespace CalculateApp.Controllers
{
    [Route("Calculate")]
    public class ArithmeticController : Controller
    {
        [HttpGet]
        [Route("Add")]
        public IActionResult Addition([FromQuery] int n1, [FromQuery] int n2)
        {
            
            HttpClient client = new HttpClient();
            string url = string.Format("https://localhost:44392/AddService/Add?n1={0}&n2={1}", n1,n2);
            HttpResponseMessage response = client.GetAsync(url).Result;
            if(response.IsSuccessStatusCode)
            {
                return new JsonResult("The result of addition is " + response.Content.ReadAsStringAsync().Result);
            }

            throw new Exception("Internal server error");
        }

        [HttpGet]
        [Route("Subtract")]
        public IActionResult Subtraction([FromQuery] int n1, [FromQuery] int n2)
        {

            HttpClient client = new HttpClient();
            string url = string.Format("https://localhost:44356/SubtractService/Subtract?n1={0}&n2={1}", n1, n2);
            HttpResponseMessage response = client.GetAsync(url).Result;
            if (response.IsSuccessStatusCode)
            {
                return new JsonResult("The result of subtraction is " + response.Content.ReadAsStringAsync().Result);
            }

            throw new Exception("Internal server error");
        }

        [HttpGet]
        [Route("Multiply")]
        public IActionResult Multiplication()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("Divide")]
        public IActionResult Division()
        {
            throw new NotImplementedException();
        }
    }
}

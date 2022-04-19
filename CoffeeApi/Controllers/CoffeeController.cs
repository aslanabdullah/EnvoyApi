using Microsoft.AspNetCore.Mvc;

namespace CoffeeApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoffeeController : ControllerBase
    {
        private static readonly string[] Teas = new[]
        {            
            "Flat White", "Long Black", "Latte", "Americano", "Cappuccino"
        };


        [HttpGet]
        public ActionResult Get()
        {
            var rng = new Random();

            return Ok(Teas[rng.Next(Teas.Length)]);
        }
    }
}
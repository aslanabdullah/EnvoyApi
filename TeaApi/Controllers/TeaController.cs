using Microsoft.AspNetCore.Mvc;

namespace TeaApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeaController : ControllerBase
    {
        private static readonly string[] Coffees = new[]
        {
            "Green", "Peppermint", "Earl Grey", "English Breakfast", "Camomile"
        };


        [HttpGet]
        public ActionResult Get()
        {
            var rng = new Random();

            return Ok(Coffees[rng.Next(Coffees.Length)]);
        }
    }
}
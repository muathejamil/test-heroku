using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace heroku_test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HerosController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> Get()
        {
            var heros = new List<SuperHero>
            { new SuperHero {
                Id = 1,
                Name = "Spider Man",
                FirstName = "Peter",
                SecondName = "Tamer",
                Place = "New York City"}
            };

            return Ok(heros);
        }
    }
}

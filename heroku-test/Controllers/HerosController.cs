using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace heroku_test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> Get()
        {
            var heros = new List<SuperHero>
            { new SuperHero {
                Id = 1,
                Name = "Ahmad",
                FirstName = "Tamer",
                SecondName = "Luis",
                Place = "New York City"},
                new SuperHero {
                Id = 2,
                Name = "Monther",
                FirstName = "Arafat",
                SecondName = "Mother",
                Place = "Ramallah"},
                new SuperHero {
                Id = 2,
                Name = "Samer",
                FirstName = "Peter",
                SecondName = "Meme",
                Place = "New York City"}
            };

            return Ok(heros);
        }
    }
}

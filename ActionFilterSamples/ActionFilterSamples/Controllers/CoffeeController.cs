using ActionFilterSamples.Services;
using Microsoft.AspNetCore.Mvc;

namespace ActionFilterSamples.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoffeeController : ControllerBase
    {
        private readonly ICoffeeService coffeeService;

        public CoffeeController(ICoffeeService coffeeService)
        {
            this.coffeeService = coffeeService;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var coffee = coffeeService.GetById(id);

            //if (coffee == null) return NotFound();

            return Ok(coffee);
        }

    }
}

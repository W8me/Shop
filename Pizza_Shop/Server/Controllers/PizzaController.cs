using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pizza_Shop.Server.Data;
using Pizza_Shop.Server.Services.PizzaService;
using Pizza_Shop.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pizza_Shop.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private readonly IPizzaService pizzaService;

        public PizzaController(IPizzaService pizzaService)
        {
            this.pizzaService = pizzaService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Pizza>>>> GetPizzas()
        {
            var resault = await pizzaService.GetPizzasAsync();
            return Ok(resault);
        }

        [HttpGet("{pizzaId}")]
        public async Task<ActionResult<ServiceResponse<Pizza>>> GetPizzas(int pizzaId)
        {
            var resault = await pizzaService.GetPizzaAsync(pizzaId);
            return Ok(resault);
        }

        [HttpGet("category/{categoryUrl}")]
        public async Task<ActionResult<ServiceResponse<List<Pizza>>>> GetPizzasByCategory(string categoryUrl)
        {
            var resault = await pizzaService.GetPizzasByCategory(categoryUrl);
            return Ok(resault);
        }

        [HttpGet("search/{searchText}")]
        public async Task<ActionResult<ServiceResponse<List<Pizza>>>> SearchPizzas(string searchText)
        {
            var resault = await pizzaService.SearchPizzas(searchText);
            return Ok(resault);
        }

        [HttpGet("searchSuggestions/{searchText}")]
        public async Task<ActionResult<ServiceResponse<List<Pizza>>>> GetPizzaSearchSuggestions(string searchText)
        {
            var resault = await pizzaService.GetPizzaSearchSuggestions(searchText);
            return Ok(resault);
        }
    }
}

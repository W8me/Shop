using Pizza_Shop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza_Shop.Server.Services.PizzaService
{
    public interface IPizzaService
    {
        Task<ServiceResponse<List<Pizza>>> GetPizzasAsync();
        Task<ServiceResponse<Pizza>> GetPizzaAsync(int pizzaId);
        Task<ServiceResponse<List<Pizza>>> GetPizzasByCategory(string categoryUrl);
        Task<ServiceResponse<List<Pizza>>> SearchPizzas(string searchText);
        Task<ServiceResponse<List<string>>> GetPizzaSearchSuggestions(string searchText);

    }
}

using Pizza_Shop.Shared;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Pizza_Shop.Client.ServicesC.PizzaServicesC
{
    public interface IPizzaServiceC
    {
        event Action PizzasChanged;
        List<Pizza> Pizzas { get; set; }
        string Massage { get; set; }
        Task GetPizzas(string? categoryUrl = null);
        Task<ServiceResponse<Pizza>> GetPizzaById(int pizzaId);
        Task SearchPizza(string searchText);
        Task<List<string>> GetPizzaSearchSuggestions(string searchText);

    }
}

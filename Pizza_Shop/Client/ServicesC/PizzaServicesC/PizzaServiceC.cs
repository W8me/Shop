using Pizza_Shop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Pizza_Shop.Client.ServicesC.PizzaServicesC
{
    public class PizzaServiceC : IPizzaServiceC
    {
        private readonly HttpClient http;

        public PizzaServiceC(HttpClient http)
        {
            this.http = http;
        }
        public List<Pizza> Pizzas { get; set; } = new List<Pizza>();
        public string Massage { get; set; } = "Loading pizzas...";

        public event Action PizzasChanged;

        public async Task<ServiceResponse<Pizza>> GetPizzaById(int pizzaId)
        {
            var resault = await http.GetFromJsonAsync<ServiceResponse<Pizza>>($"api/Pizza/{pizzaId}");
            return resault;
        }

        public async Task GetPizzas(string? categoryUrl = null)
        {
            var resault = categoryUrl == null ?
                await http.GetFromJsonAsync<ServiceResponse<List<Pizza>>>("api/Pizza") :
                await http.GetFromJsonAsync<ServiceResponse<List<Pizza>>>($"api/Pizza/category/{categoryUrl}");

            if (resault != null && resault.Data != null)
                Pizzas = resault.Data;

            PizzasChanged.Invoke();
        }

        public async Task<List<string>> GetPizzaSearchSuggestions(string searchText)
        {
            var resault = 
                await http.GetFromJsonAsync<ServiceResponse<List<string>>>($"api/pizza/searchSuggestions/{searchText}"); //TODO:fix searchSugg
            return resault.Data;
        }

        public async Task SearchPizza(string searchText)
        {
            var resault = 
                await http.GetFromJsonAsync<ServiceResponse<List<Pizza>>>($"api/pizza/search/{searchText}");
           
            if (resault != null && resault.Data != null)
                Pizzas = resault.Data;

            if (Pizzas.Count == 0)
                Massage = "Pizza not found";

            PizzasChanged?.Invoke();
        }
    }

}

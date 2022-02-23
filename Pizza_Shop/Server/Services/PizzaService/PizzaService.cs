using Microsoft.EntityFrameworkCore;
using Pizza_Shop.Server.Data;
using Pizza_Shop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza_Shop.Server.Services.PizzaService
{
    public class PizzaService : IPizzaService
    {
        private readonly DataContext context;
        public PizzaService(DataContext context)
        {
            this.context = context;
        }

        public async Task<ServiceResponse<Pizza>> GetPizzaAsync(int pizzaId)
        {
            var response = new ServiceResponse<Pizza>();
            var pizza = await context.Pizzas.FindAsync(pizzaId);

            if (pizza == null)
            {
                response.Success = false;
                response.Messege = "Sorry, but this pizza does not exist";
            }
            else
            {
                response.Data = pizza;
            }

            return response;
        }

        public async Task<ServiceResponse<List<Pizza>>> GetPizzasAsync()
        {
            var response = new ServiceResponse<List<Pizza>>
            {
                Data = await context.Pizzas.ToListAsync()
            };
            return response;
        }

        public async Task<ServiceResponse<List<Pizza>>> GetPizzasByCategory(string categoryUrl)
        {
            var response = new ServiceResponse<List<Pizza>>
            {
                Data = await context.Pizzas
                .Where(p => p.Category.Url.ToLower().Equals(categoryUrl.ToLower()))
                .ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<List<string>>> GetPizzaSearchSuggestions(string searchText)
        {
            var pizzas = await FindPizzaBySearchText(searchText);

            List<string> resault = new List<string>();

            foreach (var pizza in pizzas)
            {
                if (pizza.Title.Contains(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    resault.Add(pizza.Title);
                }            
            }

            return new ServiceResponse<List<string>> { Data = resault };
        }

        public async Task<ServiceResponse<List<Pizza>>> SearchPizzas(string searchText)
        {
            var response = new ServiceResponse<List<Pizza>>
            {
                Data = await FindPizzaBySearchText(searchText)
            };
            return response;
        }

        private async Task<List<Pizza>> FindPizzaBySearchText(string searchText)
        {
            var response = await context.Pizzas
                             .Where(p => p.Title.ToLower().Contains(searchText.ToLower()) ||
                              p.Description.ToLower().Contains(searchText.ToLower()))
                             .ToListAsync();
            return response;
        }
    }
}

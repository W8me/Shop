using Pizza_Shop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Pizza_Shop.Client.ServicesC.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient http;

        public CategoryService(HttpClient http)
        {
            this.http = http;
        }
        public List<Category> Categories { get; set; } = new List<Category>();

        public async Task GetCategories()
        {
            var resault = await http.GetFromJsonAsync<ServiceResponse<List<Category>>>("api/Category");
            if (resault != null && resault.Data != null)
                Categories = resault.Data;
        }
    }
}

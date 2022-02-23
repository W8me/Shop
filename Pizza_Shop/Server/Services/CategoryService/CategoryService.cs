using Microsoft.EntityFrameworkCore;
using Pizza_Shop.Server.Data;
using Pizza_Shop.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizza_Shop.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext context;

        public CategoryService(DataContext  context)
        {
            this.context = context;
        }
        public async Task<ServiceResponse<List<Category>>> GetCattegories()
        {
            var categories = await context.Categories.ToListAsync();
            return new ServiceResponse<List<Category>>
            {
                Data = categories
            };
        }
    }
}

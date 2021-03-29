using DrinkAndGo.Data.Interfaces;
using DrinkAndGo.Data.Models;
using System;
using System.Collections.Generic;

namespace DrinkAndGo.Data.Repositores
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext ??
                throw new ArgumentNullException(nameof(appDbContext));
        }

        public IEnumerable<Category> Categories => _appDbContext.Categories;
    }
}

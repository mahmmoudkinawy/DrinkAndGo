﻿using DrinkAndGo.Data.Interfaces;
using DrinkAndGo.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Data.Repositores
{
    public class DrinkRepository : IDrinkRepository
    {
        private readonly AppDbContext _appDbContext;

        public DrinkRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext ??
                throw new ArgumentNullException(nameof(appDbContext));
        }

        public IEnumerable<Drink> Drinks => _appDbContext.Drinks.Include(c => c.Category);

        public IEnumerable<Drink> PreferedDrink => _appDbContext.Drinks.Where(p => p.IsPreferredDrink).Include(c => c.Category);

        public Drink GetDrinkById(int drinkId)
        {
            return _appDbContext.Drinks.FirstOrDefault(p => p.DrinkId == drinkId);
        }
    }
}

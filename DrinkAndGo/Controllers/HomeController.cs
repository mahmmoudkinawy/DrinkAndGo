using DrinkAndGo.Data.Interfaces;
using DrinkAndGo.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDrinkRepository _drinkRepository;

        public HomeController(IDrinkRepository drinkRepository)
        {
            _drinkRepository = drinkRepository ??
                throw new ArgumentNullException(nameof(drinkRepository));
        }

        public ViewResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                PreferredDrinks = _drinkRepository.PreferedDrink
            };

            return View(homeViewModel);
        }
    }
}

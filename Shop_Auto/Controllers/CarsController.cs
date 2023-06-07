using Shop_Auto.Data.interfaces;
using Shop_Auto.Data.Models;
using Shop_Auto.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shop_Auto.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars; // variable for interfaces
        private readonly ICarsCategory _allCategories;

        // Constructor to read elements from interfaces
        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;
        }

        [Route("Cars/Index")]
        public IActionResult Search(string searchWord)
        {
            return View("Index", _allCars.Cars.Where(c => c.Name.Contains(searchWord, StringComparison.InvariantCultureIgnoreCase)));
        }

        [Route("Cars/List")]
        [Route("Cars/List/{category}")]
        // Function that returns ViewResult
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Car> cars = null;
            string currCategory = "";
            cars = _allCars.Cars.Where(i => i.Available);
            if (string.IsNullOrEmpty(category))
            {
                // .Available.Equals("True")).  //.OrderBy(i => i.Id)
                cars = cars.OrderBy(i => i.Id);
            }
            else
            {
                if (string.Equals("electric", category, System.StringComparison.OrdinalIgnoreCase))
                {
                    cars = cars.Where(i => i.Category.CategoryName.Equals("Electric Car")).OrderBy(i => i.Id);
                    currCategory = "electric";
                }
                else if (string.Equals("gasoline", category, System.StringComparison.OrdinalIgnoreCase))
                {
                    cars = cars.Where(i => i.Category.CategoryName.Equals("Gasoline Car")).OrderBy(i => i.Id);
                    currCategory = "gasoline";
                }
            }

            var carObj = new CarsListViewModel
            {
                allCars = cars,
                CurrCategory = currCategory
            };

            ViewBag.Title = "Page with cars";
            return View(carObj);
        }

    }
}

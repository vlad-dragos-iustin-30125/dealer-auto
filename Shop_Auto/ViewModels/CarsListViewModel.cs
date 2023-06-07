using Shop_Auto.Data.Models;
using System.Collections.Generic;

namespace Shop_Auto.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> allCars { get; set; }
        public string CurrCategory { get; set; }
    }
}

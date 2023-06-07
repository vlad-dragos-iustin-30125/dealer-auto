using Shop_Auto.Data.Models;
using System.Collections.Generic;

namespace Shop_Auto.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Car> favCars { get; set; }
    }
}

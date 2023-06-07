using Shop_Auto.Data.Models;
using System.Collections.Generic;

namespace Shop_Auto.Data.interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> GetFavCars { get; }
        Car GetObjectCar(int carId);
    }
}
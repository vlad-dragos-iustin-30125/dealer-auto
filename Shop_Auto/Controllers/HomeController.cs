using Shop_Auto.Data.interfaces;
using Shop_Auto.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Shop_Auto.Controllers
{
    public class HomeController : Controller
    {
        private IAllCars _carRep;

        public HomeController(IAllCars carRep)
        {
            _carRep = carRep;
        }

        public ViewResult Index()
        {
            var homeCars = new HomeViewModel
            {
                favCars = _carRep.GetFavCars
            };
            return View(homeCars);
        }

        public ViewResult Privacy()
        {
            return View();
        }

        public ViewResult Terms()
        {
            return View();
        }
    }
}

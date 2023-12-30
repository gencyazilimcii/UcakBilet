using DataAccesLaayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class DefaultController : Controller
    {
        private readonly Context context = new Context();

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult FlySearch()
        {
            return View(context.Flights.ToList());
        }

        [HttpPost]
        public ActionResult FlySearch(string Departure, string Arrival, DateTime DepartureDate)
        {
            var flights = context.Flights.Where(f => f.Departure == Departure && f.Arrival == Arrival && f.DepatureDate == DepartureDate).ToList();
            return View("FlySearchResults", flights);
        }


        public IActionResult FlySearchResults()
        {
            return View();
        }
    }
}

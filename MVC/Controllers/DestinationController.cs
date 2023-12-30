using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class DestinationController : Controller
    {
        KampanyaManager kampanyaManager = new KampanyaManager(new EfKampanyaDal());
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IActionResult Index()
        {
            var values = kampanyaManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult DestinationDetails(int id)
        {

            //var values = destinationManager.TGetById(id);
            return View();
        }

        [HttpPost]
        public IActionResult DestinationDetails(Destination p)
        {
            return View();
        }

    }
}

using DataAccesLaayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace MVC.ViewComponents.Default
{
    public class _Statistics : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            //using var c = new Context();
            //ViewBag.v1 = c.Destinations.Count();
            //ViewBag.v1 = c.Destinations.Count();
            //ViewBag.v1 = c.Destinations.Count();
            return View();
        }
    }
}

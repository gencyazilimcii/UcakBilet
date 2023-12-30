using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class Contact : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

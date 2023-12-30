using BusinessLayer.Concrete;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Mvc.ViewComponents.Default
{
    public class _KampanyaPartial : ViewComponent
    {
        KampanyaManager kampanyaManager = new KampanyaManager(new EfKampanyaDal());
        public IViewComponentResult Invoke()
        {
            var values = kampanyaManager.TGetList();
            return View(values);
        }
    }
}

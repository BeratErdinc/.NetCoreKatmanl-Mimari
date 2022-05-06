using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class Last5Projects:ViewComponent
    {
        Context x = new Context();
        public IViewComponentResult Invoke()
        {
            var liste = x.Portfolios.ToList();
            return View(liste);
        }
    }
}

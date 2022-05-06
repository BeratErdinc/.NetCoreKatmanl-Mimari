using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class StatisticsDashboard2:ViewComponent
    {
        Context x = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = x.Portfolios.Count();
            ViewBag.v2=x.Messages.Count();
            ViewBag.v3=x.Services.Count();
            return View();
        }
    }
}

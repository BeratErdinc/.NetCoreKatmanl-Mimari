using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class FeatureStatistics:ViewComponent
    {
        Context x = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = x.Skill.Count();
            ViewBag.v2 = x.Messages.Where(x => x.Stat == false).Count();
            ViewBag.v3 = x.Messages.Where(x => x.Stat == true).Count();
            ViewBag.v4 = x.Experiences.Count();
            return View();
        }
    }
}

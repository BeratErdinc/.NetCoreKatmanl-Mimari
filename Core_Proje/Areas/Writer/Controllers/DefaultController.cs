using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DefaultController : Controller
    {
        AnnouncementManager announcementManager = new AnnouncementManager(new EfAnnouncement());
        Context x = new Context();
        public IActionResult Index()
        {
           var vlues= announcementManager.TGetList();
            return View(vlues);
        }
        public IActionResult AnnouncementDetay()
        {
            var lıst = announcementManager.TGetList();
            return View(lıst);
        }
    }
}

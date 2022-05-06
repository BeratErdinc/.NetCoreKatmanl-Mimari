using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers.AdminControllers.AboutController
{
    public class AboutController : Controller
    {
        AboutManager aboutManger = new AboutManager(new EfAboutDal());
        public IActionResult Index()
        {
            var valus = aboutManger.TGetList();
            return View(valus);
        }
        [HttpGet]
        public IActionResult EditAbout(int id)
        {
            var deger = aboutManger.TGetById(id);
            return View(deger);
        }
        [HttpPost]
        public IActionResult EditAbout(About sk)
        {
            aboutManger.TUpdate(sk);
            return RedirectToAction("Index");
        }
    }
}

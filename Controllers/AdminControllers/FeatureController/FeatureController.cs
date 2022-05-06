using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers.AdminControllers.FeatureController
{
    public class FeatureController : Controller
    {
        FeatureManager featureManager = new FeatureManager(new EfFeature());
        public IActionResult Index()
        {
            var valus = featureManager.TGetList();
            return View(valus);
        }
        [HttpGet]
        public IActionResult EditFeature(int id)
        {
            var deger = featureManager.TGetById(id);
            return View(deger);
        }
        [HttpPost]
        public IActionResult EditFeature(Feature sk)
        {
            featureManager.TUpdate(sk);
            return RedirectToAction("Index");
        }
    }
}

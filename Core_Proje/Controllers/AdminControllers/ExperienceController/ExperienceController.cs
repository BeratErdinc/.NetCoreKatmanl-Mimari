using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers.AdminControllers.ExperienceController
{
    [Authorize(Roles = "Admin")]
    public class ExperienceController : Controller
    {
       
        ExperienceManager experienceManager = new ExperienceManager(new EfExperience());
        public IActionResult Index()
        {
            var values = experienceManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddExperience()
        {
            return View();
               
            
        }
        [HttpPost]
        public IActionResult AddExperience(Experience ex)
        {
            experienceManager.TAdd(ex);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteExperience(int id)
        {
            var deger = experienceManager.TGetById(id);
            experienceManager.TDelete(deger);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditExperience(int id)
        {
            var deger = experienceManager.TGetById(id);
            return View(deger);
        }
        [HttpPost]
        public IActionResult EditExperience(Experience ex)
        {
           experienceManager.TUpdate(ex);
            return RedirectToAction("Index");
        }
    }
}

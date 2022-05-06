using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers.AdminControllers
{
    public class ContactController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessage());
        public IActionResult Index()
        {
            var values = messageManager.TGetList();
            return View(values);
        }
        public IActionResult MessageDelete(int id)
        {
            var values=messageManager.TGetById(id);
            messageManager.TDelete(values);
            return RedirectToAction("Index");
        }
        public IActionResult MessageDetails(int id)
        {
            var message = messageManager.TGetById(id); 
            return View();
        }
    }
}

using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;

namespace Core_Proje.Controllers
{
    public class DefaultController : Controller
    {

      

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Message p)
        {
            MessageManager messageManager = new MessageManager(new EfMessage());
            p.Date=Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Stat = true;
            messageManager.TAdd(p);
            return View();
        }
    }
}

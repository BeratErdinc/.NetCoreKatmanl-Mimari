using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]

    public class MesajlarController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public MesajlarController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        WriterMessageManager writerMessagemanager = new WriterMessageManager(new EfWriterMessage());




        public async Task<IActionResult> Index(string p)
        {
            var kullanıcı = await _userManager.FindByNameAsync(User.Identity.Name);
            p = kullanıcı.Email;
            var messsagelist = writerMessagemanager.GetListReceiverMessages(p);
            return View(messsagelist);
        }
        public async Task<IActionResult> Reciver(string p)
        {
            var kullanıcı = await _userManager.FindByNameAsync(User.Identity.Name);
            p = kullanıcı.Email;
            var messsagelist = writerMessagemanager.GetListReceiverMessages(p);
            return View(messsagelist);
        }
        [HttpGet]
        public IActionResult MesajDetay(int id)
        {
            WriterMessage writerMessage = writerMessagemanager.TGetById(id);
            return View(writerMessage);
        }
        
        [HttpGet]
        public IActionResult MessageSend()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> MessageSend(WriterMessage p)
        {
            var kullanıcı = await _userManager.FindByNameAsync(User.Identity.Name);
            string mail = kullanıcı.Email;
            string name = kullanıcı.Name + "" + kullanıcı.Surname;
            p.Date=Convert.ToDateTime(DateTime.Now.ToShortDateString());
            p.Sender = mail;
            writerMessagemanager.TAdd(p);
            return View();

        }
    }
}

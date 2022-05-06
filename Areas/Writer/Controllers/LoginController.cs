using Core_Proje.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]

    public class LoginController : Controller
    {
        private readonly SignInManager<WriterUser> _writeruser;

        public LoginController(SignInManager<WriterUser> sıngmanager)
        {
            _writeruser = sıngmanager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserLoginViewModel userlog)
        {
            if (ModelState.IsValid)
            {
                var result = await _writeruser.PasswordSignInAsync(userlog.UserName, userlog.Password, true, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index","Writer","Default");
                }
                else
                {
                    ModelState.AddModelError("", "Hatalı kullaıcı adı veya şifre");
                }
            }
            return View();
        }
    }
}

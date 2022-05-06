using Core_Proje.Areas.Writer.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]

    public class RegisterController : Controller
    {
        private readonly UserManager<WriterUser> userManger;

        public RegisterController(UserManager<WriterUser> userManger)
        {
            this.userManger = userManger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new UserRegisterViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel urvm )
        {
          
                WriterUser w = new WriterUser()
                {
                    Name = urvm.Name,
                    Surname = urvm.Surname,
                    Email = urvm.Mail,
                    UserName = urvm.UserName,
                    ImageUrl = urvm.ImageUrl
                };
                var result = await userManger.CreateAsync(w, urvm.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("/Index","Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
              
            
           
            return View(urvm);
        }
    }
}

using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class ProfilController : Controller
    {
        private readonly UserManager<WriterUser> _usermanager;

        public ProfilController(UserManager<WriterUser> usermanager)
        {
            _usermanager = usermanager;
        }

        public async Task<IActionResult> Index()
        {
            var kullanıcı = await _usermanager.FindByNameAsync(User.Identity.Name);
            return View(kullanıcı);
        }
    }
}

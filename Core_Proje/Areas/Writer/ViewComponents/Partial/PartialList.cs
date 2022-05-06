using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Areas.Writer.ViewComponents.Partial
{
    public class PartialList:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}

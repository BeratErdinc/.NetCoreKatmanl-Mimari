using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class MessageList:ViewComponent
    {
        UserMessageManager userMessageManager = new UserMessageManager(new EfUserMessage());
        public IViewComponentResult Invoke()
        {
            var values = userMessageManager.GetUserMessagesWithUserService();
            return View(values);
               
            
        }
    }
}

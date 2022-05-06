using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Skill
{
    public class SkillList:ViewComponent
    {
        SkillManager skillManeger = new SkillManager(new EfSkill());
        public IViewComponentResult Invoke()
        {
            var values = skillManeger.TGetList();
            return View(values);
        }
    }
}

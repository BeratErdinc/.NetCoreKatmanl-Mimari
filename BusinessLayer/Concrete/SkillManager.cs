using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SkillManager : ISkıllServices
    {
        ISkill _skill;

        public SkillManager(ISkill skill)
        {
            _skill = skill;
        }

     

        public void TAdd(Skill t)
        {
            _skill.Insert(t);
        }

        public void TDelete(Skill t)
        {
            _skill.Delete(t);
        }

        public Skill TGetById(int id)
        {
           return _skill.GetById(id);
        }

        public List<Skill> TGetList()
        {
            return _skill.GetList();

        }

        public List<Skill> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Skill t)
        {
            _skill.Update(t);
        }
    }
}

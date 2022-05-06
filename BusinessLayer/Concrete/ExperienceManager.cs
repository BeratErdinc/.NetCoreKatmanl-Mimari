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
    public class ExperienceManager : IExperienceServices
    {
        IExperience _experience;

        public ExperienceManager(IExperience experience)
        {
            _experience = experience;
        }
        public List<Experience> TGetList()
        {
            return _experience.GetList();
        }

        public void TAdd(Experience t)
        {
          _experience.Insert(t);
        }

        public void TDelete(Experience t)
        {
            _experience.Delete(t);
        }

        public Experience TGetById(int id)
        {
           return  _experience.GetById(id);
        }

        public void TUpdate(Experience t)
        {
          _experience.Update(t);
        }

        public List<Experience> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }
    }
}

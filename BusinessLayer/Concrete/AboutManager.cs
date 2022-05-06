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
    public class AboutManager : IAboutServicecs
    {
        IAboutDal _about;

        public AboutManager(IAboutDal about)
        {
            _about = about;
        }

        public List<About> TGetList()
        {
          return  _about.GetList();
        }

        public void TAdd(About t)
        {
            _about.Insert(t);
            
        }

        public void TDelete(About t)
        {
            _about.Delete(t);
        }

        public About TGetById(int id)
        {
            return _about.GetById(id);
        }

        public void TUpdate(About t)
        {
            _about.Update(t);
        }

        public List<About> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }
    }
}

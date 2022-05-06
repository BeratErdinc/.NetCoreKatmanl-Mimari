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
    internal class SocialMediaManager : ISocialMediaServices
    {
        ISocialMedia _socialMedia;

        public SocialMediaManager(ISocialMedia socialMedia)
        {
            _socialMedia = socialMedia;
        }

        public List<SocialMedia> TGetList()
        {
            return _socialMedia.GetList();
        }

        public void TAdd(SocialMedia t)
        {
            _socialMedia.Insert(t);
        }

        public void TDelete(SocialMedia t)
        {
            _socialMedia.Delete(t);
        }

        public SocialMedia TGetById(int id)
        {
            return _socialMedia.GetById(id);
        }

        public void TUpdate(SocialMedia t)
        {
            _socialMedia.Update(t);
        }

        public List<SocialMedia> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }
    }
}

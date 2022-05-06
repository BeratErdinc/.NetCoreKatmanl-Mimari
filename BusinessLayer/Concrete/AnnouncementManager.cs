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
    public class AnnouncementManager : IAnnouncementServices
    {
        IAnnouncement _Iannouncement;

        public AnnouncementManager(IAnnouncement ıannouncement)
        {
            _Iannouncement = ıannouncement;
        }

        public void TAdd(Announcement t)
        {
            _Iannouncement.Insert(t);
        }

        public void TDelete(Announcement t)
        {
            _Iannouncement.Delete(t);
        }

        public Announcement TGetById(int id)
        {
            return _Iannouncement.GetById(id);
        }

        public List<Announcement> TGetList()
        {
            return _Iannouncement.GetList();
        }

        public List<Announcement> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Announcement t)
        {
            _Iannouncement.Update(t);
        }
    }
}

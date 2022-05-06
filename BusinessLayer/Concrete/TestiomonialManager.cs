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
    public class TestiomonialManager : ITestiomonialServices
    {
        ITestiomonial _testimonial;
        public TestiomonialManager(ITestiomonial testiomonial)
        {
            _testimonial = testiomonial;
        }
    

        public void TAdd(Testimonial t)
        {
            _testimonial.Insert(t);
        }

        public void TDelete(Testimonial t)
        {
            _testimonial.Delete(t);
        }

        public Testimonial TGetById(int id)
        {
           return _testimonial.GetById(id);
        }

        public List<Testimonial> TGetList()
        {
           return _testimonial.GetList();
        }

        public List<Testimonial> TGetListbyFilter()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Testimonial t)
        {
            _testimonial.Update(t);
        }
    }
}

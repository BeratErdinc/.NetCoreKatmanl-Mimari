using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramwork;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Testimonials
{
    public class TestimonialsList:ViewComponent
    {
        TestiomonialManager testimonialManager = new TestiomonialManager(new EfTestimonial());
        public IViewComponentResult Invoke()
        {
            var values = testimonialManager.TGetList();
            return View(values);
        }
    }
}

using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayers.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimoniaDal;

        public TestimonialManager(ITestimonialDal testimoniaDal)
        {
            _testimoniaDal = testimoniaDal;
        }

        public void TDelete(Testimonial t)
        {
            _testimoniaDal.Delete(t);
        }

        public Testimonial TGetById(int id)
        {
            return _testimoniaDal.GetById(id);
        }

        public List<Testimonial> TGetList()
        {
            return _testimoniaDal.GetList();
        }

        public void TInsert(Testimonial t)
        {
             _testimoniaDal.Insert(t);
        }

        public void TUpdate(Testimonial t)
        {
            _testimoniaDal.Update(t);
        }
    }
}

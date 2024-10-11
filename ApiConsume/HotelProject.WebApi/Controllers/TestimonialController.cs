using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayers.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;
        public TestimonialController(ITestimonialService testimoniaService)
        {
            _testimonialService = testimoniaService;
        }

        [HttpGet]
        public IActionResult TestimoniaList()
        {
            var values = _testimonialService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddTestimonia(Testimonial testimonia)
        {
            _testimonialService.TInsert(testimonia);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteTestimonia(int id)
        {
            var values = _testimonialService.TGetById(id);
            _testimonialService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateTestimonia(Testimonial testimonia)
        {
            _testimonialService.TUpdate(testimonia);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetTestimonia(int id)
        {
            var values = _testimonialService.TGetById(id);

            return Ok(values);
        }
    }
}

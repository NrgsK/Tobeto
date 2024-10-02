using Business.Abstracts;
using Entities.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        ICourseService _courseService;

        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll() 
        { 
            var result = _courseService.GetAll();
            return Ok(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Course course)
        {
            var result=_courseService.Add(course);
            return Ok(result);
        }
    }
}

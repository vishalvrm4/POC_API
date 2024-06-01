using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RESTAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        public readonly StudentModel student;
        public HomeController()
        {
            student = new StudentModel()
            {
                Id=1,Name="Vishal Verma",Age=15
            };
        }

        [HttpGet("asdf")]
        public StudentModel Get()
        {
            return student;
        }
    }
}

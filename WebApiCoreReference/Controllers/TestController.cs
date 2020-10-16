using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApiCoreReference.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class TestController : ControllerBase
    {
        public TestController()
        {

        }   
        
        [HttpGet("[action]")]
        public IActionResult Ping()
        {
            var response = new { Pong = "Pong" };
            return Ok(response);
        }
    }
}

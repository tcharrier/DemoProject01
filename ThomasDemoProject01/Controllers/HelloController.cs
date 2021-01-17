using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ThomasDemoProject01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet("{name}")]
        public ActionResult<string> Get(string name)
        {
            return string.Format("Hello {0}", name);
        }
    }
}
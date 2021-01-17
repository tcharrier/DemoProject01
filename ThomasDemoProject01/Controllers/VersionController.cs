using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace ThomasDemoProject01.Controllers
{
    public class Version
    {
        public int current { get; set; }
        public string version { get; set; }
        public string info { get; set; }
    }

    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class VersionController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Version>> Get()
        {
 
            List<Version> versions = new List<Version>(); ;
            versions.Add(new Version { current = 0, version = "1.0.0", info = "Version 1 !" });
            versions.Add(new Version { current = 1, version = "1.0.1", info = "Version 1.0.1, much better !" });

            return versions;
        }

    }
}
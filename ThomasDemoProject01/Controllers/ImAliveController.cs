﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ThomasDemoProject01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImAliveController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "I'm Alive";
        }
    }
}
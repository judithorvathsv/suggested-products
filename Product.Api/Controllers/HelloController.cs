using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace Product.Api.Controllers
{
    [ApiController, Route("api/vi/[controller]")]

    public class HelloController : ControllerBase
    {
    

        public HelloController()
        {
           
        }

        [HttpGet]

        public string SayHello()=> "Hello";

    }
}
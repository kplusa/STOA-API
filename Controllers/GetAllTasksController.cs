using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace STOA_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetAllTasksController : ControllerBase
    {
        // GET: api/<GetAllTasksController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("task 1 - to dishes - test");
        }
    }
}

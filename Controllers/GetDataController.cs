using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace STOA_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetDataController : ControllerBase
    {

        private IConfiguration _configuration;

        public GetDataController(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        // GET: api/<GetDataController>
        [HttpGet]
        public IActionResult Get()
        {
            string connString = Startup.ConnectionString;

            SqlConnection connection = new SqlConnection(connString);
            connection.Open();

            SqlCommand cmd = new SqlCommand("SelectUserData", connection);

            var result = (string)cmd.ExecuteScalar();
            return Ok(result);
        }
    }
}




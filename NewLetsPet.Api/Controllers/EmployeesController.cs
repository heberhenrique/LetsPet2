using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewLetsPet.Domain.Employees;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NewLetsPet.Api.Controllers
{
    [Route("api/[controller]")]
    public class EmployeesController : Controller
    {
        [HttpPost]
        public IActionResult Post([FromBody]Employee value)
        {
            return Ok();
        }
    }
}


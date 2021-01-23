using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCalculadora.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculadoraController : Controller
    {
     
      
            [HttpGet]
            [Route ("suma")]
            public int suma(int num1, int num2)
            {
                return num1 + num2;
            }
            [HttpPost]
            [Route("suma")]
            public int sumar([FromHeader] int num1, [FromHeader] int num2)
            {
                return num1 + num2;
            }

        [HttpGet]
        [Route("resta")]
        public int resta(int num1, int num2)
        {
            return num1 - num2;
        }
        [HttpPost]
        [Route("resta")]
        public int restar([FromHeader] int num1, [FromHeader] int num2)
        {
            return num1 - num2;
        }



    }
}

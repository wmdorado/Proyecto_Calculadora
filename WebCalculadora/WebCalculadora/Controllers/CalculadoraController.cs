﻿using Microsoft.AspNetCore.Mvc;
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
            public int suma(int num1, int num2)
            {
                return num1 + num2;
            }
            [HttpPost]
            public int sumar([FromHeader] int num1, [FromHeader] int num2)
            {
                return num1 + num2;
            }
        
    }
}
